using System;
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
        public static HashSet.HashSet<int> Create(int[] elems)
        {
            
            PexAssume.IsTrue(elems != null && elems.Length < 11);
            PexAssume.TrueForAll(0, elems.Length, _i => elems[_i] > -11 && elems[_i] < 11);
            HashSet.HashSet<int> ret = new HashSet.HashSet<int>(elems.Length + 2);// DataStructure has big enough capacity for Commutativity Test
            for (int i = 0; i < elems.Length; i++)
            {
                //PexAssume.IsTrue(elems[i] > -101 && elems[i] < 101);

                // For stack, add any element. 
                if(!ret.Contains(elems[i]))
                    ret.Add(elems[i]);
            }
           
            return ret;

        }

    }
}