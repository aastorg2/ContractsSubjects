using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientAPI;
using PexAPIWrapper;

namespace ClientAPI.Test
{
    [TestClass]
    [PexClass(typeof(StackClient))]
    public partial class ClientStackTest
    {
        //[TestMethod]
        [PexMethod]
        public string PUT_ToBinaryStackTest([PexAssumeUnderTest]StackClient clientStack,int n)
        {
            //var clientStack = new StackClient();

            string output = clientStack.ToBinaryStack(n);
            return output;
        }

        [PexMethod]
        public string PUT_ToBinaryStackSummaryTest([PexAssumeUnderTest]StackClient clientStack, int n)
        {
            //var clientStack = new StackClient();

            string output = clientStack.ToBinaryStackSummary(n);
            return output;
        }
    }
}
