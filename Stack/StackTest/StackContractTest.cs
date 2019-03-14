using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;
using Stack.Utility;
using PexAPIWrapper;

namespace Stack.Test
{
    [PexClass,TestClass]
    public partial class StackContractTest
    {
        /* Post Condition with entropy:
         * ((New_s1ContainsX) && (New_Top == Old_x) && (New_s1Count == 1 + Old_s1Count) && (New_Top == New_x) && (Old_s1ContainsX)) || 
         * ((New_s1ContainsX) && (New_Top == Old_x) && (New_s1Count == 1 + Old_s1Count) && (New_Top == New_x) && ( ! (Old_Top == New_Top)))
         * 
         * 
         * Post Condition with max conjuncts:
         * 
         * 
         */

        //[PexMethod(TestEmissionFilter= PexTestEmissionFilter.All)]
        //[PexMethod(TestEmissionFilter= PexTestEmissionFilter.FailuresAndUniquePaths, MaxRuns=100)]
        [PexMethod]
        public void PUT_PushContract([PexAssumeUnderTest]Stack.Stack<int> s1, int x)
        {
            int Old_s1Count =  s1.Count;
            //int Old_Top = s1.Count > 0 ? s1.Peek() : -200;
            int Old_Top = s1.Peek();
            int Old_x = x;
            bool Old_s1ContainsX = s1.Contains(x);

            AssumePrecondition.IsTrue(true);
            s1.Push(x);

            int New_s1Count = s1.Count;
            int New_Top = s1.Peek();
            int New_x = x;
            bool New_s1ContainsX = s1.Contains(x);

            PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            PexObserve.ValueForViewing("$old_s1_x", Old_x);
            PexObserve.ValueForViewing("$new_s1_x", New_x);
            PexObserve.ValueForViewing("$old_s1_contains_x", Old_s1ContainsX);
            PexObserve.ValueForViewing("$new_s1_contains_x", New_s1ContainsX);
            
            PexAssert.IsTrue(((New_s1ContainsX) && (New_x == Old_x) && (New_s1Count == 1 + Old_s1Count) && (New_Top == Old_x) && (Old_s1ContainsX)) || ((New_s1ContainsX) && (New_x == Old_x) && (New_s1Count == 1 + Old_s1Count) && (New_Top == Old_x) && ( ! (Old_Top == New_Top))));
        }


        [PexMethod(TestEmissionFilter= PexTestEmissionFilter.FailuresAndUniquePaths, MaxRuns=100)]
        public void PUT_PopContract([PexAssumeUnderTest]Stack.Stack<int> s1)
        {
            AssumePrecondition.IsTrue(s1.Count > 0);
            int Old_s1Count = s1.Count;
            int Old_ret = -12;
            int Old_Top = s1.Peek();
            
            /*code*/
            int New_ret = s1.Pop();
            
            Old_ret = New_ret;
            int New_Top = s1.Peek();
            int New_s1Count = s1.Count;
            
            PexObserve.ValueForViewing("$Old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$New_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$Old_s1_Peek", Old_Top);
            PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            //PexObserve.ValueForViewing("$Old_ret", Old_ret);
            //PexObserve.ValueForViewing("$New_ret", New_ret);
            
            PexAssert.IsTrue((( ! (Old_s1Count == New_Top)) && ( ! (New_s1Count == New_Top)) && (Old_Top == New_Top) && (New_s1Count == -1 + Old_s1Count) && (New_Top == 0)));

        }

        [PexMethod]
        public void PUT_PeekContract([PexAssumeUnderTest]Stack.Stack<int> s1)
        {

            PexAssume.IsTrue(s1.Count > 0);


            int Old_s1Count = s1.Count;
            int Old_ret = -12 ;
            
            AssumePrecondition.IsTrue(true);
            
            int New_ret = s1.Peek();

            int New_s1Count = s1.Count;
            Old_ret = New_ret;

            PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$old_s1_ret", Old_ret);
            PexObserve.ValueForViewing("$new_ret", New_ret);
            //PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            //PexObserve.ValueForViewing("$new_s1_Peek", New_Top);


            PexAssert.IsTrue(((Old_s1Count == New_ret) && (New_s1Count == New_ret) && (New_ret == Old_ret)) || (( ! (Old_s1Count == Old_ret)) && ( ! (New_s1Count == Old_ret)) && ( ! (New_s1Count == New_ret)) && ( ! (Old_s1Count == New_ret))));

        }

    }
}