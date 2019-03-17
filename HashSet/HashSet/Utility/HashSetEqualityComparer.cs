using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace HashSet.Utility
{
    /// <summary>
    /// Equality comparer for hashsets of hashsets
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class HashSetEqualityComparer<T> : IEqualityComparer<HashSet<T>>
    {
        private readonly IEqualityComparer<T> m_comparer;

        public HashSetEqualityComparer()
        {
            m_comparer = EqualityComparer<T>.Default;
        }

        // using m_comparer to keep equals properties in tact; don't want to choose one of the comparers
        public bool Equals(HashSet<T> x, HashSet<T> y)
        {
            // return HashSet<T>.HashSetEquals(x, y, m_comparer);
            return x.SetEquals(y);
        
        }

        public int GetHashCode(HashSet<T> obj)
        {
            int hashCode = 0;
            if (obj != null)
            {
                foreach (T t in obj)
                {
                    hashCode = hashCode ^ (m_comparer.GetHashCode(t) & 0x7FFFFFFF);
                }
            } // else returns hashcode of 0 for null hashsets
            return hashCode;
        }

        // Equals method for the comparer itself. 
        public override bool Equals(object obj)
        {
            HashSetEqualityComparer<T> comparer = obj as HashSetEqualityComparer<T>;
            if (comparer == null)
            {
                return false;
            }
            return (m_comparer == comparer.m_comparer);
        }

        public override int GetHashCode()
        {
            return m_comparer.GetHashCode();
        }
    }
}
