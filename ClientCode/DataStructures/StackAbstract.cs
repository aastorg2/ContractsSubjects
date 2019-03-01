using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using DataStructures.Utility;
using PexAPIWrapper;
using Microsoft.Pex.Framework;

namespace DataStructures
{
    public class StackAbstract
    {
        int _top = 0;
        int _count = 0;
        bool _containsX = false;

        public StackAbstract()
        {
            _count = 0;
        }

        public int Count
        {
            get
            {
                int oldTop = _top;
                int oldCount = _count;
                bool oldContainsX = _containsX;
                int ret = 0;

                PexAssert.IsTrue(true); 
                PexAssume.IsTrue(oldCount == _count && oldContainsX == _containsX && oldTop == _top && ret == _count);

                _top = PexChoose.Value<int>("_topCount");
                _count = PexChoose.Value<int>("_countCount");
                _containsX = PexChoose.Value<bool>("_containsXCount");
                ret = PexChoose.Value<int>("_retCount");
                
                return ret;
            }
        }

        public int Top
        {
            get
            {
                int oldTop = _top;
                int oldCount = _count;
                bool oldContainsX = _containsX;
                int ret = 0;

                PexAssert.IsTrue(_count > 0);
                PexAssume.IsTrue(oldCount == _count && oldContainsX == _containsX && oldTop == _top && ret == _top);

                _top = PexChoose.Value<int>("_topTop");
                _count = PexChoose.Value<int>("_countTop");
                _containsX = PexChoose.Value<bool>("_containsXTop");
                ret = PexChoose.Value<int>("_retTop");

                return ret;
            }
        }

        public void Push(int x)
        {
            int oldX = x;
            int oldTop = _top;
            int oldCount = _count;
            // bool oldContainsX = _containsX;

            PexAssert.IsTrue(true);
            PexAssume.IsTrue((_containsX == true)  && (_top == oldX) && (_count == oldCount + 1) && (oldX == x));

            _top = PexChoose.Value<int>("_topPush");
            _count = PexChoose.Value<int>("_countPush");
            _containsX = PexChoose.Value<bool>("_containsXPush");
        }

        public int Pop()
        {
            int oldTop = _top;
            int oldCount = _count;
            bool oldContainsX = _containsX;
            int ret = 0;

            PexAssert.IsTrue(_count > 0);
            PexAssume.IsTrue((_count == oldCount - 1) && (ret == _top));

            _top = PexChoose.Value<int>("_topPop");
            _count = PexChoose.Value<int>("_countPop");
            _containsX = PexChoose.Value<bool>("_containsXPop");
            ret = PexChoose.Value<int>("_retPop");

            return ret;
        }
    }
}
