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
    //[PexClass, TestClass]
    public partial class StackContractTest
    {
        //[PexMethod(TestEmissionFilter= PexTestEmissionFilter.All)]
        [PexMethod]
        public void PUT_PushContract_Debug([PexAssumeUnderTest]Stack.Stack<int> s1, int x, int y)
        {
            PexAssume.IsTrue(s1.Count > 0);
            
            AssumePrecondition.IsTrue(true);
            
            s1.Push(x);

            PexAssert.IsTrue(true);

        }
    }
}
