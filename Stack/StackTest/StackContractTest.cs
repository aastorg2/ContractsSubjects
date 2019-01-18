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
        //[PexMethod(TestEmissionFilter= PexTestEmissionFilter.All)]
        [PexMethod]
        public void PUT_PushContract([PexAssumeUnderTest]Stack.Stack<int> s1, int x)
        {
            
            //PexAssume.IsTrue(s1.Count > 0);

            

            //intVariables = ['Old_s1Count', 'New_s1Count','Old_Top','New_Top', 'Old_x','New_x']
            //boolVariables = ["New_s1ContainsX", "Old_s1ContainsX"]

            int Old_s1Count = s1.Count;
            int Old_Top = s1.Peek();
            int Old_x = x;
            bool Old_s1ContainsX = s1.Contains(x);

            //PexAssume.IsTrue(Old_x != Old_Top); 

            AssumePrecondition.IsTrue(true);
            //PexObserve.ValueForViewing("$input_Old_s1Count", s1.Count);
            //PexObserve.ValueForViewing("$input_Old_s1Peek", s1.Peek());
            //PexObserve.ValueForViewing("$input_x", x);

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

            PexAssert.IsTrue(((New_s1ContainsX) && (Old_s1Count == 1) && (New_s1Count == 2) && (Old_Top == 10) && (New_Top == 0) && (Old_x == 0) && (New_x == 0)));
            
        }


        [PexMethod]
        public void PUT_PopContract([PexAssumeUnderTest]Stack.Stack<int> s1)
        {

            PexAssume.IsTrue(s1.Count > 0);



            //intVariables = ['Old_s1Count', 'New_s1Count','Old_Top','New_Top', 'Old_x','New_x']
            //boolVariables = ["New_s1ContainsX", "Old_s1ContainsX"]

            int Old_s1Count = s1.Count;
            //int Old_Top = s1.Peek();
            //int Old_x = x;
            //bool Old_s1ContainsX = s1.Contains(x);

            //PexAssume.IsTrue(Old_x != Old_Top); 

            AssumePrecondition.IsTrue(true);
            //PexObserve.ValueForViewing("$input_Old_s1Count", s1.Count);
            //PexObserve.ValueForViewing("$input_Old_s1Peek", s1.Peek());
            //PexObserve.ValueForViewing("$input_x", x);

            int New_ret = s1.Pop();

            int New_s1Count = s1.Count;
            //int New_Top = s1.Peek();
            //int New_x = x;
            //bool New_s1ContainsX = s1.Contains(x);

            PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$new_ret", New_ret);
            //PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            //PexObserve.ValueForViewing("$new_s1_Peek", New_Top);


            PexAssert.IsTrue(((Old_s1Count == 1) && (New_s1Count == 0) && (New_ret == 10)));

        }

        [PexMethod]
        public void PUT_PeekContract([PexAssumeUnderTest]Stack.Stack<int> s1)
        {

            PexAssume.IsTrue(s1.Count > 0);



            //intVariables = ['Old_s1Count', 'New_s1Count','Old_Top','New_Top', 'Old_x','New_x']
            //boolVariables = ["New_s1ContainsX", "Old_s1ContainsX"]

            int Old_s1Count = s1.Count;
            //int Old_Top = s1.Peek();
            //int Old_x = x;
            //bool Old_s1ContainsX = s1.Contains(x);

            //PexAssume.IsTrue(Old_x != Old_Top); 

            AssumePrecondition.IsTrue(true);
            //PexObserve.ValueForViewing("$input_Old_s1Count", s1.Count);
            //PexObserve.ValueForViewing("$input_Old_s1Peek", s1.Peek());
            //PexObserve.ValueForViewing("$input_x", x);

            int New_ret = s1.Peek();

            int New_s1Count = s1.Count;
            //int New_Top = s1.Peek();
            //int New_x = x;
            //bool New_s1ContainsX = s1.Contains(x);

            PexObserve.ValueForViewing("$old_s1_Count", Old_s1Count);
            PexObserve.ValueForViewing("$new_s1_Count", New_s1Count);
            PexObserve.ValueForViewing("$new_ret", New_ret);
            //PexObserve.ValueForViewing("$old_s1_Peek", Old_Top);
            //PexObserve.ValueForViewing("$new_s1_Peek", New_Top);


            PexAssert.IsTrue(((Old_s1Count == 1) && (New_s1Count == 1) && (New_ret == 10)));

        }

    }
}
