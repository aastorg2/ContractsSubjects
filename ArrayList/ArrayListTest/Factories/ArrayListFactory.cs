using System;
using System.Text;
using ArrayList;
using Common.Utility;
using Microsoft.Pex.Framework;

namespace ArrayList.Test.Factories
{
    
    public static class ArrayListFactory
    {
        [PexFactoryMethod(typeof(ArrayList))]
        public static ArrayList Create([PexAssumeNotNull]int[] elems)
        {
            //PexAssume.IsTrue( elems.Length < 11);
            //PexAssume.TrueForAll(0, elems.Length, _i => elems[_i] > -11 && elems[_i] < 11);
            ArrayList ret = new ArrayList(elems.Length + 2);

            
            for (int i = 0; i < elems.Length; i++)
            {
                //if (!ret.Contains(elems[i]))
                    ret.Add(elems[i]);
            }
            
            return ret;

        }
        


    }
}
