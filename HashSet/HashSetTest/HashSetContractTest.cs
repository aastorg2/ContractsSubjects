﻿using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
using NUnit.Framework;
using HashSet;
using PexAPIWrapper;

namespace HashSet.Test
{
    [PexClass, TestFixture]
    public partial class HashSetContractTest
    {
        [PexMethod]
        public void PUT_AddContract([PexAssumeUnderTest]HashSet.HashSet<int> hs, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_hsCount = hs.Count;
            int Old_x = x;
            bool Old_hsContainsX = hs.Contains(x);

            //code
            bool New_Ret = hs.Add(x);


            int New_hsCount = hs.Count;
            bool New_hsContainsX = hs.Contains(x);

            PexObserve.ValueForViewing("$old_hs_Count", Old_hsCount);
            PexObserve.ValueForViewing("$new_hs_Count", New_hsCount);
            PexObserve.ValueForViewing("$old_hs_x", Old_x);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_hs_contains_x", Old_hsContainsX);
            PexObserve.ValueForViewing("$new_hs_contains_x", New_hsContainsX);

            Assert.True(((New_hsContainsX && (!(New_Ret)) && Old_hsContainsX && New_hsCount == Old_hsCount && Old_hsCount >= 1) || (New_hsContainsX && (!(Old_hsContainsX)) && New_Ret && New_hsCount == 1 + Old_hsCount && New_hsCount >= 1)));
        }

        [PexMethod]
        public void PUT_RemoveContract([PexAssumeUnderTest]HashSet.HashSet<int> hs, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_hsCount = hs.Count;
            int Old_x = x;
            bool Old_hsContainsX = hs.Contains(x);

            bool New_Ret = hs.Remove(x);

            int New_hsCount = hs.Count;
            bool New_hsContainsX = hs.Contains(x);

            PexObserve.ValueForViewing("$old_hs_Count", Old_hsCount);
            PexObserve.ValueForViewing("$new_hs_Count", New_hsCount);
            PexObserve.ValueForViewing("$old_hs_x", Old_x);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_hs_contains_x", Old_hsContainsX);
            PexObserve.ValueForViewing("$new_hs_contains_x", New_hsContainsX);


            Assert.True((((!(New_hsContainsX)) && New_Ret && Old_hsContainsX && New_hsCount == -1 + Old_hsCount && Old_hsCount >= 1) || ((!(New_hsContainsX)) && (!(Old_hsContainsX)) && (!(New_Ret)) && New_hsCount == Old_hsCount && Old_hsCount >= 0)));
        }

        [PexMethod]
        public void PUT_CountContract([PexAssumeUnderTest]HashSet.HashSet<int> hs)
        {
            AssumePrecondition.IsTrue(true);

            //int Old_hsCount = hs.Count;
            

            int New_Ret = hs.Count;
            
            //code
            //int New_hsCount = hs.Count;
            //bool New_ContainsNewRet = hs.Contains(New_Ret); 

            //PexObserve.ValueForViewing("$old_hs_Count", Old_hsCount);
            //PexObserve.ValueForViewing("$new_hs_Count", New_hsCount);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            //PexObserve.ValueForViewing("$new_containsNewRet", New_ContainsNewRet);

            Assert.True((New_Ret >= 1 || New_Ret == 0));
        }

        [PexMethod]
        public void PUT_ContainsContract([PexAssumeUnderTest]HashSet.HashSet<int> hs, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_hsCount = hs.Count;
            int Old_x = x;
            //bool Old_hsContainsX = hs.Contains(x);
            //code
            bool New_Ret = hs.Contains(x);

            int New_hsCount = hs.Count;
            //bool New_hsContainsX = hs.Contains(x);

            PexObserve.ValueForViewing("$old_hs_Count", Old_hsCount);
            PexObserve.ValueForViewing("$new_hs_Count", New_hsCount);
            PexObserve.ValueForViewing("$old_x", Old_x);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            //PexObserve.ValueForViewing("$old_hs_contains_x", Old_hsContainsX);
            //PexObserve.ValueForViewing("$new_hs_contains_x", New_hsContainsX);

            Assert.True(((New_hsCount == Old_hsCount && (!(New_Ret)) && Old_hsCount >= 0) || (New_hsCount == Old_hsCount && Old_hsCount >= 1)));
        }
    }
}