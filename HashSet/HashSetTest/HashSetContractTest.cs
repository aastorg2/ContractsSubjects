using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashSet;
using PexAPIWrapper;

namespace HashSet.Test
{
    [PexClass, TestClass]
    public partial class HashSetContractTest
    {
        [PexMethod]
        public void PUT_AddContract([PexAssumeUnderTest]HashSet.HashSet<int> hs, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_hsCount = hs.Count;
            int Old_x = x;
            bool Old_Ret = PexChoose.Value<bool>("default_Ret");
            //bool Old_Ret = ;
            bool Old_hsContainsX = hs.Contains(x);

            //code
            bool New_Ret = hs.Add(x);

            int New_hsCount = hs.Count;
            int New_x = x;
            bool New_hsContainsX = hs.Contains(x);

            PexObserve.ValueForViewing("$old_hs_Count", Old_hsCount);
            PexObserve.ValueForViewing("$new_hs_Count", New_hsCount);
            PexObserve.ValueForViewing("$old_hs_x", Old_x);
            PexObserve.ValueForViewing("$new_hs_x", New_x);
            PexObserve.ValueForViewing("$Old_ret", Old_Ret);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_hs_contains_x", Old_hsContainsX);
            PexObserve.ValueForViewing("$new_hs_contains_x", New_hsContainsX);

            PexAssert.IsTrue(((New_hsContainsX) && (New_x == Old_x) && (New_Ret) && ( ! (Old_hsCount == New_hsCount))) || ((New_hsContainsX) && (New_x == Old_x) && (Old_hsCount == New_hsCount) && (Old_hsContainsX)));
        }

        [PexMethod]
        public void PUT_RemoveContract([PexAssumeUnderTest]HashSet.HashSet<int> hs, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_hsCount = hs.Count;
            int Old_x = x;
            bool Old_Ret = PexChoose.Value<bool>("default_Ret");
            bool Old_hsContainsX = hs.Contains(x);

            bool New_Ret = hs.Remove(x);

            int New_hsCount = hs.Count;
            int New_x = x;
            bool New_hsContainsX = hs.Contains(x);

            PexObserve.ValueForViewing("$old_hs_Count", Old_hsCount);
            PexObserve.ValueForViewing("$new_hs_Count", New_hsCount);
            PexObserve.ValueForViewing("$old_hs_x", Old_x);
            PexObserve.ValueForViewing("$new_hs_x", New_x);
            PexObserve.ValueForViewing("$Old_ret", Old_Ret);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_hs_contains_x", Old_hsContainsX);
            PexObserve.ValueForViewing("$new_hs_contains_x", New_hsContainsX);


            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_CountContract([PexAssumeUnderTest]HashSet.HashSet<int> hs)
        {
            AssumePrecondition.IsTrue(true);

            int Old_hsCount = hs.Count;
            int Old_Ret = 2;

            int New_Ret = hs.Count;

            int New_hsCount = hs.Count;

            PexObserve.ValueForViewing("$old_hs_Count", Old_hsCount);
            PexObserve.ValueForViewing("$new_hs_Count", New_hsCount);
            PexObserve.ValueForViewing("$Old_ret", Old_Ret);
            PexObserve.ValueForViewing("$New_ret", New_Ret);

            PexAssert.IsTrue(false);

        }

        [PexMethod]
        public void PUT_ContainsContract([PexAssumeUnderTest]HashSet.HashSet<int> hs, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_hsCount = hs.Count;
            int Old_x = x;
            bool Old_Ret = PexChoose.Value<bool>("default_Ret");
            bool Old_hsContainsX = hs.Contains(x);

            bool New_Ret = hs.Contains(x);

            int New_hsCount = hs.Count;
            int New_x = x;
            bool New_hsContainsX = hs.Contains(x);

            PexObserve.ValueForViewing("$old_hs_Count", Old_hsCount);
            PexObserve.ValueForViewing("$new_hs_Count", New_hsCount);
            PexObserve.ValueForViewing("$old_hs_x", Old_x);
            PexObserve.ValueForViewing("$new_hs_x", New_x);
            PexObserve.ValueForViewing("$Old_ret", Old_Ret);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_hs_contains_x", Old_hsContainsX);
            PexObserve.ValueForViewing("$new_hs_contains_x", New_hsContainsX);


            PexAssert.IsTrue(false);

        }
    }
}