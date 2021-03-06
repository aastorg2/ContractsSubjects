﻿using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Stack;
using Stack.Utility;
using PexAPIWrapper;
using Stack.Test.Factories;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace Stack.Test
{
    [PexClass]
    public partial class StackContractTest
    {
        //[PexMethod(TestEmissionFilter= PexTestEmissionFilter.All)]
        //[PexMethod(TestEmissionFilter= PexTestEmissionFilter.FailuresAndUniquePaths, MaxRuns=100)]
        //[PexMethod(Timeout=500,MaxConstraintSolverTime = 10,MaxRunsWithoutNewTests = 2147483647,MaxRuns = 2147483647)]
        [PexMethod]
        public void PUT_PushContract([PexAssumeUnderTest]Stack.Stack<int> s1, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_s1Count = s1.Count;
            int Old_Top = s1.Count > 0 ? s1.Peek() : PexChoose.Value<int>("old_top");
            //int Old_Top = s1.Count > 0 ? s1.Peek() : x--;
            //int Old_Top = s1.Peek();
            int Old_x = x;
            bool Old_s1ContainsX = s1.Contains(x);

            s1.Push(x);

            int New_s1Count = s1.Count;
            int New_Top = s1.Peek();
            bool New_s1ContainsX = s1.Contains(x);

            PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            PexObserve.ValueForViewing("$old_s1_x", Old_x);
            PexObserve.ValueForViewing("$Old_s1ContainsX", Old_s1ContainsX);
            PexObserve.ValueForViewing("$New_s1ContainsX", New_s1ContainsX);

            Assert.True(((New_s1ContainsX && New_Top == Old_x && New_s1Count == 1 + Old_s1Count) && (((!(Old_s1ContainsX)) && New_s1Count >= 1) || (Old_s1Count >= 1 && ((!(1 == Old_Top))) || ((!(1 == Old_s1Count))) || (New_Top <= New_s1Count))))

);
        }


        [PexMethod]
        public void PUT_PopContract([PexAssumeUnderTest]Stack.Stack<int> s1)
        {
            AssumePrecondition.IsTrue(s1.Count > 0);
            int Old_s1Count = s1.Count;
            int Old_Top = s1.Peek();

            /*code*/
            int New_Ret = s1.Pop();

            //Old_ret = New_ret;
            int New_Top = s1.Count > 0 ? s1.Peek() : PexChoose.Value<int>("old_top");
            //int New_Top = s1.Count > 0 ? s1.Peek() : Old_Top - 1;
            int New_s1Count = s1.Count;
            bool New_ContainsNewRet = s1.Contains(New_Ret);

            PexObserve.ValueForViewing("$Old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$New_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$Old_s1_Peek", Old_Top);
            PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$New_ContainsNewRet", New_ContainsNewRet);

            Assert.True(((New_Ret == Old_Top && New_s1Count == -1 + Old_s1Count && (!(New_ContainsNewRet)) && Old_s1Count >= 1) || (New_Ret == Old_Top && New_s1Count == -1 + Old_s1Count && New_s1Count >= 1)));

        }

        [PexMethod]
        public void PUT_PeekContract([PexAssumeUnderTest]Stack.Stack<int> s1)
        {
            AssumePrecondition.IsTrue(s1.Count > 0);
            int Old_s1Count = s1.Count;


            /*Code */
            int New_Ret = s1.Peek();

            int New_s1Count = s1.Count;
            bool New_ContainsNewRet = s1.Contains(New_Ret);

            PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);

            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$New_ContainsNewRet", New_ContainsNewRet);

            Assert.True(((New_ContainsNewRet && New_s1Count == Old_s1Count && Old_s1Count >= 1)));
        }

        [PexMethod]
        public void PUT_CountContract([PexAssumeUnderTest]Stack.Stack<int> s1)
        {

            AssumePrecondition.IsTrue(true);
            //int Old_Ret = PexChoose.Value<int>("old_ret");
            int Old_Top = s1.Count > 0 ? s1.Peek() : PexChoose.Value<int>("old_top");

            /*Code */
            int New_Ret = s1.Count;

            int New_Top = s1.Count > 0 ? s1.Peek() : PexChoose.Value<int>("new_top");
            //int New_Top = Old_Top; // consult about this decision later
            //bool New_ContainsNewRet = s1.Contains(New_Ret);

            PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            //PexObserve.ValueForViewing("$old_s1_ret", Old_Ret);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            //PexObserve.ValueForViewing("$New_ContainsNewRet", New_ContainsNewRet);

            Assert.True(((Old_Top <= New_Ret && New_Ret >= 0) || (New_Top == Old_Top && New_Ret >= 0 && Old_Top >= 1) || (New_Top == Old_Top && New_Ret == 0) || (New_Ret == 0 && New_Top >= 1) || (New_Top <= Old_Top && New_Ret == 0) || (New_Top <= Old_Top && New_Top <= 0 && New_Ret == 0)));

        }
        [PexMethod]
        public void PUT_ContainsContract([PexAssumeUnderTest]Stack.Stack<int> s1, int x)
        {
            int undefinedTop = PexChoose.Value<int>("old_top");

            AssumePrecondition.IsTrue(true);
            int Old_s1Count = s1.Count;
            int Old_Top = s1.Count > 0 ? s1.Peek() : undefinedTop;

            /*Code */
            bool New_Ret = s1.Contains(x);

            int New_s1Count = s1.Count;
            //int New_Top = s1.Count > 0 ? s1.Peek() : undefinedTop;
            int New_Top = s1.Count > 0 ? s1.Peek() : PexChoose.Value<int>("new_top");

            PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            PexObserve.ValueForViewing("$new_ret", New_Ret);

            Assert.True(((New_s1Count == Old_s1Count && (!(New_Ret)) && New_s1Count >= 0) || (New_s1Count == Old_s1Count && New_Top == Old_Top && New_s1Count >= 1)));
        }

      
    }
}