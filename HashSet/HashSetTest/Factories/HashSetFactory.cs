//using System.Collections.Generic;
using System.Linq;
using System.Text;
using HashSet;
using Microsoft.Pex.Framework;

namespace HashSet.Test.Factories
{
    public static class HashSetFactory
    {
        [PexFactoryMethod(typeof(HashSet.HashSet<int>))]
        public static HashSet.HashSet<int> Create([PexAssumeNotNull]int[] elems)
        {
            
            //PexAssume.IsTrue(elems != null && elems.Length < 11);
            //PexAssume.TrueForAll(0, elems.Length, _i => elems[_i] > -11 && elems[_i] < 11);
            PexAssume.AreDistinctValues(elems);
            PexAssume.TrueForAll(0, elems.Length, _i => elems[_i] <= 0 || elems[_i] > 0);
            PexAssume.IsTrue(elems.Length <= 2 || elems.Length > 2);
            HashSet.HashSet<int> ret = new HashSet.HashSet<int>();// DataStructure has big enough capacity for Commutativity Test
            for (int i = 0; i < elems.Length; i++)
            {
                //PexAssume.IsTrue(elems[i] > -101 && elems[i] < 101);

                // For stack, add any element. 
                //if(!ret.Contains(elems[i]))
                    ret.Add(elems[i]);
            }
           
            return ret;

        }
        
        [PexFactoryMethod(typeof(HashSet.HashSet<int>))]
        public static HashSet.HashSet<int> CreateChoose(int min, int max)
        {

            //PexAssume.IsTrue(elems != null && elems.Length < 11);
            
            //PexAssume.AreDistinctValues(elems);
            //PexChoose.
            PexAssume.IsTrue(min <= 0 ||min > 0);
            PexAssume.IsTrue(max <= 0 || max > 0);
            HashSet.HashSet<int> ret = new HashSet.HashSet<int>();// DataStructure has big enough capacity for Commutativity Test
            //for (int i = 0; i < elems.Length; i++)
            //{
                //PexAssume.IsTrue(elems[i] > -101 && elems[i] < 101);

                // For stack, add any element. 
                //if(!ret.Contains(elems[i]))
                ret.Add(PexChoose.ValueFromRange("elements",min,max));
            //}

            return ret;

        }

    }
}