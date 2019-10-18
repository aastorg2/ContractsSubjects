using System;
using System.Text;
using Dictionary;
using Common.Utility;
using Microsoft.Pex.Framework;

namespace Dictionary.Test.Factories
{
    public static class DictionaryFactory
    {
        /*[PexFactoryMethod(typeof(Dictionary.Dictionary<int, int>))]
        public static Dictionary<int, int> Create([PexAssumeNotNull]int[] keys,[PexAssumeNotNull] int[] values)
        {

            PexAssume.IsTrue( keys.Length < 11 && keys.Length == values.Length);
            PexAssume.TrueForAll(0, keys.Length, _i => keys[_i] > -11 && keys[_i] < 11);
            PexAssume.TrueForAll(0, values.Length, _j => values[_j] > -11 && values[_j] < 11);
            //DataStructures.Utility.Int32EqualityComparer comparer = new DataStructures.Utility.Int32EqualityComparer();

            Dictionary.Dictionary<int, int> ret = new Dictionary.Dictionary<int, int>(keys.Length, EqualityComparer<int>.Default);// DataStructure has big enough capacity for Commutativity Test
            for (int i = 0; i < keys.Length; i++)
            {
                // For stack, add any element. 
                if (!ret.ContainsKey(keys[i]))
                    ret.Add(keys[i], values[i]);
            }
            return ret;

        }*/

        [PexFactoryMethod(typeof(Dictionary.Dictionary<int, int>))]
        public static Dictionary<int, int> createDictionaryArrays([PexAssumeNotNull]int[] keys, int max)
        {
            PexAssume.AreDistinctValues(keys);
            PexAssume.IsTrue(max > 0);
            PexAssume.IsTrue(keys.Length <= 5 || keys.Length > 5);
            
            //PexAssume.TrueForAll(pairs, p => (p.Key > -11 && p.Key < 11) && (p.Value > -11 && p.Value < 11));
            //DataStructures.Utility.Int32EqualityComparer comparer = new DataStructures.Utility.Int32EqualityComparer();

            Dictionary.Dictionary<int, int> ret = new Dictionary.Dictionary<int, int>();// DataStructure has big enough capacity for Commutativity Test
            for (int i = 0; i < keys.Length; i++)
            {
                    ret.Add(keys[i],PexChoose.ValueFromRange("value",0, max));

            }
            return ret;

        }

    }
}