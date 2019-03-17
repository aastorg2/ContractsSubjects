using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Dictionary.Utility
{
    /*This only works if int is not a collection*/
    public class DictionaryEqualityComparer : EqualityComparer<Dictionary<int, int>>
    {
        public readonly IEqualityComparer<int> mkey_comparer;
        public readonly IEqualityComparer<int> mval_comparer;

        public DictionaryEqualityComparer()
        {
            //mkey_comparer = new Int32EqualityComparer();
            //mval_comparer = new Int32EqualityComparer();
            mkey_comparer = EqualityComparer<int>.Default;
            mval_comparer = EqualityComparer<int>.Default;
        }

        // using m_comparer to keep equals properties in tact; don't want to choose one of the comparers
        public override bool Equals(Dictionary<int, int> x, Dictionary<int, int> y)
        {
            // handle null cases first
            if (x == null)
            {
                return (y == null);
            }
            else if (y == null)
            {
                // set1 != null
                return false;
            }

            if (x.Count != y.Count)
            {
                return false;
            }
            foreach (KeyValuePair<int, int> p in x)
            {
                if ((!y.ContainsKey(p.Key) || !mval_comparer.Equals(y[p.Key], p.Value)))
                {
                    return false;
                }

            }

            return true;
        }

        public override int GetHashCode(Dictionary<int, int> obj)
        {
            int hashCode = 0;
            if (obj != null)
            {
                foreach (KeyValuePair<int, int> t in obj)
                {
                    hashCode += hashCode ^ (mkey_comparer.GetHashCode(t.Key) ^ mval_comparer.GetHashCode(t.Value) & 0x7FFFFFFF);
                }
            } // else returns hashcode of 0 for null hashsets
            return hashCode;
        }

        // Equals method for the comparer itself. 
        public override bool Equals(object obj)
        {
            DictionaryEqualityComparer comparer = obj as DictionaryEqualityComparer;
            if (comparer == null)
            {
                return false;
            }
            return (mkey_comparer == comparer.mkey_comparer && mval_comparer == comparer.mval_comparer);
        }

        public override int GetHashCode()
        {
            return mkey_comparer.GetHashCode() ^ mval_comparer.GetHashCode();
        }

    }
}
