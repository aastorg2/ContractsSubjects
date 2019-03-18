using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stack;
using Microsoft.Pex.Framework;

namespace Stack.Test.Factories
{
    public static class StackFactory
    {
        /*
        [PexFactoryMethod(typeof(Stack.Stack<int>))]
        public static Stack.Stack<int> CreateEmtpyStack()
        {

            //PexAssume.TrueForAll(0, elems.Length, _i => elems[_i] > -101 && elems[_i] < 101);
            Stack.Stack<int> ret = new Stack.Stack<int>();
            return ret;

        }
        [PexFactoryMethod(typeof(Stack.Stack<int>))]
        public static Stack.Stack<int> CreateSingleElementStack(int ele)
        {
            PexAssume.IsTrue(ele != 1);
            //PexAssume.TrueForAll(0, elems.Length, _i => elems[_i] > -101 && elems[_i] < 101);
            Stack.Stack<int> ret = new Stack.Stack<int>();
            ret.Push(ele);
            return ret;

        }

        [PexFactoryMethod(typeof(Stack.Stack<int>))]
        public static Stack.Stack<int> CreateMultiElementStack([PexAssumeNotNull]int[] elems)
        {
            PexAssume.AreDistinctValues(elems);
            PexAssume.TrueForAll(elems, e => e != 0);
            //PexAssume.TrueForAll(0, elems.Length, _i => elems[_i] > -101 && elems[_i] < 101);
            Stack.Stack<int> ret = new Stack.Stack<int>();// DataStructure has big enough capacity for Commutativity Test
            for (int i = 0; i < elems.Length; i++)
            {
                 // For stack, add any element. 
                 ret.Push(elems[i]);
            }
            return ret;

        }*/
        [PexFactoryMethod(typeof(Stack.Stack<int>))]
        public static Stack.Stack<int> Create([PexAssumeNotNull]int[] elems)
        {
            //PexAssume.AreDistinctValues(elems);
            //PexAssume.TrueForAll(elems, e => e != 0);
            PexAssume.TrueForAll(0, elems.Length, _i => elems[_i] > -11 && elems[_i] < 11);
            Stack.Stack<int> ret = new Stack.Stack<int>();// DataStructure has big enough capacity for Commutativity Test
            for (int i = 0; i < elems.Length; i++)
            {
                // For stack, add any element. 
                ret.Push(elems[i]);
            }
            return ret;

        }
    }
}
