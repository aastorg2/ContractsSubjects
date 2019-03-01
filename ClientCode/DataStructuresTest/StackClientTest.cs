using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;
using DataStructures.Utility;
using PexAPIWrapper;

namespace DataStructures.Test
{
    [TestClass]
    [PexClass]
    public partial class ClientStackTest
    {
        //[TestMethod]
        [PexMethod]
        public string PUT_ToBinaryStackTest(int n)
        {
            var clientStack = new StackClient();

            string output = clientStack.ToBinaryStack(n);
            return output;
        }

        [PexMethod]
        public string PUT_ToBinaryStackSummaryTest(int n)
        {
            var clientStack = new StackClient();

            string output = clientStack.ToBinaryStackSummary(n);
            return output;
        }
    }
}
