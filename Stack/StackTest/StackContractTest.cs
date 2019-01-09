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
        public void PUT_PushContract([PexAssumeUnderTest]Stack.Stack<int> s1, int x, int y)
        {
            
            PexAssume.IsTrue(s1.Count > 0);
            
            
            int old_s1_Count = s1.Count;
            int old_s1_Peek = s1.Peek();
            int old_s1_x = x;
            bool old_s1_contains_x = s1.Contains(x);
            PexObserve.ValueForViewing("$old_s1_Count", old_s1_Count);
            PexObserve.ValueForViewing("$old_s1_Peek", old_s1_Peek);
            PexObserve.ValueForViewing("$old_s1_x", old_s1_x);
            PexObserve.ValueForViewing("$old_s1_contains_x", old_s1_contains_x);
            
            AssumePrecondition.IsTrue(true);
            //PexObserve.ValueForViewing("$input_Old_s1Count", s1.Count);
            //PexObserve.ValueForViewing("$input_Old_s1Peek", s1.Peek());
            //PexObserve.ValueForViewing("$input_x", x);

            s1.Push(x);
            
            int new_s1_Count = s1.Count;
            int new_s1_Peek = s1.Peek();
            int new_s1_x = x;
            bool new_s1_contains_x = s1.Contains(x); 
            PexObserve.ValueForViewing("$new_s1_Count", new_s1_Count);
            PexObserve.ValueForViewing("$new_s1_Peek", new_s1_Peek);
            PexObserve.ValueForViewing("$new_s1_x", new_s1_x);
            PexObserve.ValueForViewing("$new_s1_contains_x", new_s1_contains_x);

            PexAssert.IsTrue(true);
            
        }
    }
}
