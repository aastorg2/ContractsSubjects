// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Common.Utility;
using System.Diagnostics.Contracts;

namespace Stack
{

     /*[DebuggerTypeProxy(typeof(StackDebugView<>))]
     [DebuggerDisplay("Count = {Count}")]
     [Serializable]
     //[System.Runtime.CompilerServices.TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
       
     /* 
     * Source Code Adapted From: https://github.com/dotnet/corefx/blob/master/src/System.Collections/src/System/Collections/Generic/Stack.cs
     * 
     */
    public class Stack<T> : IEnumerable<T>,
        System.Collections.ICollection/*,
        IReadOnlyCollection<T>*/
    {
        private T[] _array; // Storage for stack elements. Do not rename (binary serialization)
        private int _size; // Number of items in the stack. Do not rename (binary serialization)
        private int _version; // Used to keep enumerator in sync w/ collection. Do not rename (binary serialization)
        [NonSerialized]
        private object _syncRoot;

        private const int DefaultCapacity = 4;

        public int Capacity()
        {
            return _array.Length;
        }

        public Stack()
        {
            _array = EmptyArray<T>.Value;

        }

        // Create a stack with a specific initial capacity.  The initial capacity
        // must be a non-negative number.
        public Stack(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException("Invalid object: capacity < 0");
            _array = new T[capacity];
        }

        public int Count
        {
            get { return _size; }
        }


        // Removes all Objects from the Stack.
        public void Clear()
        {
            //if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
            //{
            Array.Clear(_array, 0, _size); // Don't need to doc this but we clear the elements so that the gc can reclaim the references.
            //}
            _size = 0;
            _version++;
        }

        public bool Contains(T item)
        {
            // Compare items using the default equality comparer

            // PERF: Internally Array.LastIndexOf calls
            // EqualityComparer<T>.Default.LastIndexOf, which
            // is specialized for different types. This
            // boosts performance since instead of making a
            // virtual method call each iteration of the loop,
            // via EqualityComparer<T>.Default.Equals, we
            // only make one virtual call to EqualityComparer.LastIndexOf.

            return _size != 0 && Array.LastIndexOf(_array, item, _size - 1) != -1;
        }

        // Copies the stack into an array.
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Invalid: array == null");
            }

            if (arrayIndex < 0 || arrayIndex > array.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid index: arrayIndex < 0 || arrayIndex > array.Length");
            }

            if (array.Length - arrayIndex < _size)
            {
                throw new ArgumentException("Invalid length: array.Length - arrayIndex < _size");
            }

            Debug.Assert(array != _array);
            int srcIndex = 0;
            int dstIndex = arrayIndex + _size;
            while (srcIndex < _size)
            {
                array[--dstIndex] = _array[srcIndex++];
            }
        }


        // Returns the top object on the stack without removing it.  If the stack
        // is empty, Peek throws an InvalidOperationException.
        public T Peek()
        {
            if (_size == 0)
            {
                ThrowForEmptyStack();
            }

            return _array[_size - 1];
        }

        public bool TryPeek(out T result)
        {
            if (_size == 0)
            {
                result = default(T);
                return false;
            }
            result = _array[_size - 1];
            return true;
        }

        // Pops an item from the top of the stack.  If the stack is empty, Pop
        // throws an InvalidOperationException.
        public T Pop()
        {
            if (_size == 0)
            {
                ThrowForEmptyStack();
            }

            _version++;
            T item = _array[--_size];

            //if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
            //{
            _array[_size] = default(T);     // Free memory quicker.
            //}
            return item;
        }


        public bool TryPop(out T result)
        {
            if (_size == 0)
            {
                result = default(T);
                return false;
            }

            _version++;
            result = _array[--(_size)];
            //if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
            //{
            _array[_size] = default(T);     // Free memory quicker.
            //}
            return true;
        }

        // Pushes an item to the top of the stack.
        public void Push(T item)
        {
            if (_size == _array.Length)
            {
                Array.Resize(ref _array, (_array.Length == 0) ? DefaultCapacity : 2 * _array.Length);
            }
            
            _array[_size++] = item;
            _version++;
        }

        // Copies the Stack to an array, in the same order Pop would return the items.
        public T[] ToArray()
        {
            if (_size == 0)
                return EmptyArray<T>.Value;

            T[] objArray = new T[_size];
            int i = 0;
            while (i < _size)
            {
                objArray[i] = _array[_size - i - 1];
                i++;
            }
            return objArray;
        }

        public void TrimExcess()
        {
            int threshold = (int)(((double)_array.Length) * 0.9);
            if (_size < threshold)
            {
                Array.Resize(ref _array, _size);
                _version++;
            }
        }

        private void ThrowForEmptyStack()
        {
            Debug.Assert(_size == 0);
            throw new InvalidOperationException("Empty Stack");
        }

        /* Angello's Code */
        
        public string ToStringForInts()
        {
            /* It happens that this implementation of stack keeps the top item at end of array*/
            //Assumes T overrides ToString()
            string ret = "{";
            for (int i = 0; i < _size; i++)
            {
                ret +=  _array[i].ToString()+" ";
            }

            return  ret + "}";

            
        }
        public virtual Object Clone()
        {
            Stack<int> s = new Stack<int>(_size);
            s._size = _size;
            Array.Copy(_array, 0, s._array, 0, _size);
            s._version = _version;
            return s;
        }
        /* End of Angello's Code */


        // Fills a Stack with the contents of a particular collection.  The items are
        // pushed onto the stack in the same order they are read by the enumerator.




        public Stack(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentException();
            _array = ToArray(collection, out _size);
        }

        internal static T[] ToArray<T>(IEnumerable<T> source, out int length)
        {
            if (source is ICollection<T>)
            {
                ICollection<T> ic = (ICollection<T>)source;
                int count = ic.Count;
                if (count != 0)
                {
                    // Allocate an array of the desired size, then copy the elements into it. Note that this has the same
                    // issue regarding concurrency as other existing collections like List<T>. If the collection size
                    // concurrently changes between the array allocation and the CopyTo, we could end up either getting an
                    // exception from overrunning the array (if the size went up) or we could end up not filling as many
                    // items as 'count' suggests (if the size went down).  This is only an issue for concurrent collections
                    // that implement ICollection<T>, which as of .NET 4.6 is just ConcurrentDictionary<TKey, TValue>.
                    T[] arr = new T[count];
                    ic.CopyTo(arr, 0);
                    length = count;
                    return arr;
                }
            }
            else
            {
                using (var en = source.GetEnumerator())
                {
                    if (en.MoveNext())
                    {
                        const int DefaultCapacity = 4;
                        T[] arr = new T[DefaultCapacity];
                        arr[0] = en.Current;
                        int count = 1;

                        while (en.MoveNext())
                        {
                            if (count == arr.Length)
                            {
                                // MaxArrayLength is defined in Array.MaxArrayLength and in gchelpers in CoreCLR.
                                // It represents the maximum number of elements that can be in an array where
                                // the size of the element is greater than one byte; a separate, slightly larger constant,
                                // is used when the size of the element is one.
                                const int MaxArrayLength = 0x7FEFFFFF;

                                // This is the same growth logic as in List<T>:
                                // If the array is currently empty, we make it a default size.  Otherwise, we attempt to
                                // double the size of the array.  Doubling will overflow once the size of the array reaches
                                // 2^30, since doubling to 2^31 is 1 larger than Int32.MaxValue.  In that case, we instead
                                // constrain the length to be MaxArrayLength (this overflow check works because of the
                                // cast to uint).  Because a slightly larger constant is used when T is one byte in size, we
                                // could then end up in a situation where arr.Length is MaxArrayLength or slightly larger, such
                                // that we constrain newLength to be MaxArrayLength but the needed number of elements is actually
                                // larger than that.  For that case, we then ensure that the newLength is large enough to hold
                                // the desired capacity.  This does mean that in the very rare case where we've grown to such a
                                // large size, each new element added after MaxArrayLength will end up doing a resize.
                                int newLength = count << 1;
                                if ((uint)newLength > MaxArrayLength)
                                {
                                    newLength = MaxArrayLength <= count ? count + 1 : MaxArrayLength;
                                }

                                Array.Resize(ref arr, newLength);
                            }

                            arr[count++] = en.Current;
                        }

                        length = count;
                        return arr;
                    }
                }
            }

            length = 0;
            return Common.Utility.EmptyArray<T>.Value;
        }


        

        bool System.Collections.ICollection.IsSynchronized
        {
            get { return false; }
        }

        object System.Collections.ICollection.SyncRoot
        {
            get
            {
                if (_syncRoot == null)
                {
                    System.Threading.Interlocked.CompareExchange<object>(ref _syncRoot, new object(), null);
                }
                return _syncRoot;
            }
        }






        void System.Collections.ICollection.CopyTo(Array array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Array is null");
            }

            if (array.Rank != 1)
            {
                throw new ArgumentException("Multi dimensional array");
            }

            if (array.GetLowerBound(0) != 0)
            {
                throw new ArgumentException("Non zero lower bound");
            }

            if (arrayIndex < 0 || arrayIndex > array.Length)
            {
                throw new ArgumentOutOfRangeException("Out of range");
            }

            if (array.Length - arrayIndex < _size)
            {
                throw new ArgumentException("Invalid length");
            }

            try
            {
                Array.Copy(_array, 0, array, arrayIndex, _size);
                Array.Reverse(array, arrayIndex, _size);
            }
            catch (ArrayTypeMismatchException)
            {
                throw new ArgumentException("Invalid array type");
            }
        }
        
        // Returns an IEnumerator for this Stack.

        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        /// <internalonly/>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new Enumerator(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }
        
        

         
       



        /*
        [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = "not an expected scenario")]*/
        public struct Enumerator : IEnumerator<T>, System.Collections.IEnumerator
        {
            private readonly Stack<T> _stack;
            private readonly int _version;
            private int _index;
            private T _currentElement;

            internal Enumerator(Stack<T> stack)
            {
                _stack = stack;
                _version = stack._version;
                _index = -2;
                _currentElement = default(T);
            }

            public void Dispose()
            {
                _index = -1;
            }

            public bool MoveNext()
            {
                bool retval;
                if (_version != _stack._version) throw new InvalidOperationException("SR.InvalidOperation_EnumFailedVersion");
                if (_index == -2)
                {  // First call to enumerator.
                    _index = _stack._size - 1;
                    retval = (_index >= 0);
                    if (retval)
                        _currentElement = _stack._array[_index];
                    return retval;
                }
                if (_index == -1)
                {  // End of enumeration.
                    return false;
                }

                retval = (--_index >= 0);
                if (retval)
                    _currentElement = _stack._array[_index];
                else
                    _currentElement = default(T);
                return retval;
            }

            public T Current
            {
                get
                {
                    if (_index < 0)
                        ThrowEnumerationNotStartedOrEnded();
                    return _currentElement;
                }
            }

            private void ThrowEnumerationNotStartedOrEnded()
            {
                Debug.Assert(_index == -1 || _index == -2);
                throw new InvalidOperationException(_index == -2 ? "SR.InvalidOperation_EnumNotStarted" : "SR.InvalidOperation_EnumEnded");
            }

            object System.Collections.IEnumerator.Current
            {
                get { return Current; }
            }

            void System.Collections.IEnumerator.Reset()
            {
                if (_version != _stack._version) throw new InvalidOperationException("SR.InvalidOperation_EnumFailedVersion");
                _index = -2;
                _currentElement = default(T);
            }
        }

        
    }




}
