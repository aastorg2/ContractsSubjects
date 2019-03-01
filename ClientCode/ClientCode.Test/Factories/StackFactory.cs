using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientAPI;
using Microsoft.Pex.Framework;
using Stack;

namespace ClientAPI.Test.Factories
{
    public static class StackFactory
    {
        [PexFactoryMethod(typeof(Stack.Stack<int>))]
        public static Stack.Stack<int> Create([PexAssumeNotNull]int[] elems)
        {

            //PexAssume.IsTrue(elems != null && elems.Length < 11);
            PexAssume.TrueForAll(0, elems.Length, _i => elems[_i] > -11 && elems[_i] < 11);
            Stack.Stack<int> ret = new Stack.Stack<int>(elems.Length + 2);// DataStructure has big enough capacity for Commutativity Test
            for (int i = 0; i < elems.Length; i++)
            {
                // For stack, add any element. 
                ret.Push(elems[i]);
            }
            return ret;

        }

    }
}
