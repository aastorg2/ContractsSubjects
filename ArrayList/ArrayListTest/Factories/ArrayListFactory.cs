using System;
using System.Text;
//using Common.Utility;
using Microsoft.Pex.Framework;
using ArrayList;
using ArrayList.Utility;

namespace ArrayList.Test.Factories
{
    
    public static class ArrayListFactory
    {

        [PexFactoryMethod(typeof( ArrayList))]
        public static ArrayList Create(int[] elems)
        {
            //PexAssume.IsTrue( elems.Length < 11);
            //PexAssume.TrueForAll(0, elems.Length, _i => elems[_i] > -11 && elems[_i] < 11);
            PexAssume.IsNotNull(elems);
            ArrayList arrList = new ArrayList();
            
            for (int i = 0; i < elems.Length; i++)
            {
                //if (!ret.Contains(elems[i]))
                    arrList.Add(elems[i]);
            }
            
            return arrList;

        }

        /*[PexFactoryMethod(typeof(ArrayList))]
        public static ArrayList CreateWithConstants(int num)
        {
            PexAssume.IsTrue(num > 0 && num < 11);
            ArrayList ret = new ArrayList(num + 5);

            for (int i = 0; i < num; i++)
            {
                ret.Add(PexChoose.Value<int>("value"));
                //ret.Add(i);
            }

            return ret;
        }*/


    }
}
