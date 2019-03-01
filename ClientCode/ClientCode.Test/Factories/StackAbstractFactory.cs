using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientAPI;
using Microsoft.Pex.Framework;

namespace ClientAPI.Test.Factories
{
    public static class AbstractStackFactory
    {
        [PexFactoryMethod(typeof(ClientAPI.AbstractStack))]
        public static ClientAPI.AbstractStack CreateEmptyAbstractStack()
        {
            /*TODO: unclear how to maintain invariant count == 0 => top is undefined */
            //System.Nullable<int>();
            AbstractStack s1 = new AbstractStack(-1 , 0 , false);
            return s1;
        }
        /*
        [PexFactoryMethod(typeof(DataStructures.AbstractStack))]
        public static DataStructures.AbstractStack CreateAbstractStackWithKnownTopElement(int element)
        {
            //TODO: unclear how to maintain invariant count == 0 => top is undefined 
            //System.Nullable<int>();
            AbstractStack s1 = new AbstractStack(element, 1, true);
            return s1;
        }
        */

        [PexFactoryMethod(typeof(ClientAPI.AbstractStack))]
        public static ClientAPI.AbstractStack CreateAbstractStackWithElements(int top, int count, bool contains)
        {
            /*TODO: unclear how to maintain invariant count == 0 => top is undefined */
            //System.Nullable<int>();
            int oldTop = top;
            PexAssume.IsTrue((count == 0 ? (top == -1 && contains == false) : oldTop == top));
            //PexAssume.IsTrue(top != 0);
            AbstractStack s1 = new AbstractStack(top, count, contains);
            return s1;
        }
    }
}
