using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue;
using NUnit.Framework;
using PexAPIWrapper;

namespace Queue.Test
{
    [TestFixture, PexClass]
    public partial class QueueContractTest
    {
        //[PexMethod(Timeout = 500, MaxConstraintSolverTime = 10, MaxRunsWithoutNewTests = 2147483647, MaxRuns = 2147483647)]
        //[PexMethod(Timeout = 500, MaxConstraintSolverTime = 10, MaxRunsWithoutNewTests = 2147483647, MaxRuns = 2147483647)]
        // Adds to tail of queue
        //[PexMethod(Timeout = 500, MaxConstraintSolverTime = 10, MaxRunsWithoutNewTests = 2147483647, MaxRuns = 2147483647)]
        [PexMethod]
        public void PUT_EnqueueContract([PexAssumeUnderTest]Queue.Queue<int> s1, int x)
        {
            AssumePrecondition.IsTrue(true);
            
            int Old_s1Count =  s1.Count;

            int Old_Top = s1.Count > 0 ? s1.Peek() :  PexChoose.Value<int>("old_top");
            //int Old_Top = s1.Count > 0 ? s1.Peek() : x - 1; // OldTop = x; x updates x = x-1

            int Old_x = x;
            bool Old_s1ContainsX = s1.Contains(x);
            //bool Old_Empty = s1.Count == 0; 
            
            s1.Enqueue(x);

            int New_s1Count = s1.Count;
            int New_Top = s1.Peek();
            bool New_s1ContainsX = s1.Contains(x);
            //bool New_Empty = s1.Count == 0; 

            PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            PexObserve.ValueForViewing("$old_s1_x", Old_x);
            PexObserve.ValueForViewing("$old_s1_contains_x", Old_s1ContainsX);
            PexObserve.ValueForViewing("$new_s1_contains_x", New_s1ContainsX);
            //PexObserve.ValueForViewing("$Old_NotEmpty", Old_Empty);
            //PexObserve.ValueForViewing("$New_NotEmpty", New_Empty);
            Assert.True(false);
        }

        //remove from front of queue
        [PexMethod]
        public void PUT_DequeueContract([PexAssumeUnderTest]Queue.Queue<int> s1)
        {
            AssumePrecondition.IsTrue(true);
            
            int Old_s1Count = s1.Count;
            int Old_Top = s1.Count > 0 ? s1.Peek() : PexChoose.Value<int>("old_top"); 
            
            /*code*/
            int New_Ret = s1.Dequeue();

            int New_Top = s1.Count > 0 ? s1.Peek() : PexChoose.Value<int>("new_top"); 
            //int New_Top = s1.Count > 0 ? s1.Peek() : Old_Top - 1; // New_Top = Old_Top = OldTop - 1 
            int New_s1Count = s1.Count;
            bool New_s1ContainsNewRet = s1.Contains(New_Ret);

            PexObserve.ValueForViewing("$Old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$New_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$Old_s1_Peek", Old_Top);
            PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$New_s1ContainsNewRet", New_s1ContainsNewRet);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_PeekContract([PexAssumeUnderTest]Queue.Queue<int> s1)
        {
            AssumePrecondition.IsTrue(true);
            int Old_s1Count = s1.Count;
            //int Old_Top = s1.Peek();
            
            /*Code */
            int New_Ret = s1.Peek();

            int New_s1Count = s1.Count;
            //int New_Top = s1.Peek();
            bool New_s1ContainsNewRet = s1.Contains(New_Ret);

            PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);
            //PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            //PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            PexObserve.ValueForViewing("$New_s1ContainsNewRet", New_s1ContainsNewRet);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_CountContract([PexAssumeUnderTest]Queue.Queue<int> s1)
        {

            AssumePrecondition.IsTrue(true);
            //int Old_s1Count = s1.Count;
            int Old_Top = s1.Count > 0 ? s1.Peek() : PexChoose.Value<int>("old_top");
            
            /*Code */
            int New_Ret = s1.Count;

            //int New_s1Count = s1.Count;
            int New_Top = s1.Count > 0 ? s1.Peek() : PexChoose.Value<int>("new_top");
            //int New_Top = Old_Top; // alternate semantics
            //bool New_ContainsNewRet = s1.Contains(New_Ret);

            //PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            //PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            //PexObserve.ValueForViewing("$new_containsNewRet", New_ContainsNewRet);

            Assert.True(false);
        }
        [PexMethod]
        public void PUT_ContainsContract([PexAssumeUnderTest]Queue.Queue<int> s1, int x)
        {
            int undefinedTop = PexChoose.Value<int>("old_top");
            
            AssumePrecondition.IsTrue(true);
            
            int Old_s1Count = s1.Count;
            int Old_Top = s1.Count > 0 ? s1.Peek() : undefinedTop;
            //bool Old_s1ContainsX = s1.Contains(x);
            
            /*Code */
            bool New_Ret = s1.Contains(x);

            int New_s1Count = s1.Count;
            int New_Top = s1.Count > 0 ? s1.Peek() : PexChoose.Value<int>("new_top");
            //int New_Top = s1.Count > 0 ? s1.Peek() : Old_Top;
            
            //bool New_s1ContainsX = s1.Contains(x);

            PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            PexObserve.ValueForViewing("$new_s1_Peek", New_Top);
            PexObserve.ValueForViewing("$new_ret", New_Ret);
            //PexObserve.ValueForViewing("$old_s1_contains_x", Old_s1ContainsX);
            //PexObserve.ValueForViewing("$new_s1_contains_x", New_s1ContainsX);

            Assert.True(false);
        }

    }
}