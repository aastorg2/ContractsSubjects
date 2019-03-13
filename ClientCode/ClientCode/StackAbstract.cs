using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using PexAPIWrapper;
using Microsoft.Pex.Framework;

namespace ClientAPI
{
    public class AbstractStack
    {
        int _top;
        int _count;
        bool _containsX;

        public AbstractStack(int initTop, int initCount, bool initContainsX)
        {
            _count = initCount;
            _top = initTop;
            _containsX = initContainsX;
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
                
                _top = PexChoose.Value<int>("_topCount");
                _count = PexChoose.Value<int>("_countCount");
                _containsX = PexChoose.Value<bool>("_containsXCount");
                ret = PexChoose.Value<int>("_retCount");

                PexAssume.IsTrue(oldCount == _count && oldContainsX == _containsX && oldTop == _top && ret == _count);

               
                
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
                
                _top = PexChoose.Value<int>("_topTop");
                _count = PexChoose.Value<int>("_countTop");
                _containsX = PexChoose.Value<bool>("_containsXTop");
                ret = PexChoose.Value<int>("_retTop");

                PexAssume.IsTrue(oldCount == _count && oldContainsX == _containsX && oldTop == _top && ret == _top);

                

                return ret;
            }
        }

        public void Push(int x)
        {
            int oldX = x;
            int oldTop = _top;
            int oldCount = _count;
            bool oldContainsX = _containsX;

            PexAssert.IsTrue(true);

            _top = PexChoose.Value<int>("_topPush");
            _count = PexChoose.Value<int>("_countPush");
            _containsX = PexChoose.Value<bool>("_containsXPush");

            Debug.WriteLine("_top is: "+ _top);
            Debug.WriteLine("_count is: " + _count);
            Debug.WriteLine("_count is: " + _containsX);

            PexAssume.IsTrue((_containsX == true) && (_top == x) && (_count == oldCount + 1) && (oldX == x));
            
            //(New_s1ContainsX) && (New_Top == Old_x) && (New_s1Count == 1 + Old_s1Count) && (New_Top == New_x)
            
                    }

        public int Pop()
        {
            int oldTop = _top;
            int oldCount = _count;
            bool oldContainsX = _containsX;
            int ret = 0;

            
            PexAssert.IsTrue(_count > 0);

            _top = PexChoose.Value<int>("_topPop");
            _count = PexChoose.Value<int>("_countPop");
            _containsX = PexChoose.Value<bool>("_containsXPop");
            ret = PexChoose.Value<int>("_retPop");

            PexAssume.IsTrue((_count == oldCount - 1) && (ret == oldTop));

           

            return ret;
        }
    }
}
