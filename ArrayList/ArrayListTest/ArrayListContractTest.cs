﻿using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
//using Microsoft.VisuarrListStudio.TestTools.UnitTesting;

using NUnit.Framework;
using ArrayList;
using PexAPIWrapper;

namespace ArrayList.Test
{
    [TestFixture, PexClass]
    public partial class ArrayListContractTest
    {
        // Add x to the end of arraylist
        // PostCondition:
        // 1. New_arrListContainsX
        // 2. New_arrListCount == Old_arrListCount + 1
        // 3. New_arrListLastIndexOfX != Old_arrListLastIndexOfX 
        // 4. New_arrListLastIndexOfX == New_arrListCount - 1
        // 5. New_x == Old_x 
        // 6. New_Ret == Old_arrListCount 
        // 7. if (Old_arrListContainsX): (New_arrListIndexOfX != New_arrListLastIndexOfX) && (New_arrListIndexOfX == Old_arrListIndexOfX)
        //    if (!Old_arrListContainsX): (New_arrListIndexOfX == New_arrListLastIndexOfX) && (New_arrListIndexOfX != Old_arrListIndexOfX)

        //[PexMethod(Timeout = 500, MaxConstraintSolverTime = 10, MaxRunsWithoutNewTests = 2147483647, MaxRuns = 2147483647)]
        [PexMethod]
        public void PUT_AddContract([PexAssumeUnderTest]ArrayList arrList, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_arrListCount = arrList.Count;
            int Old_x = x;
            int Old_arrListIndexOfX = arrList.IndexOf(x);
            int Old_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool Old_arrListContainsX = arrList.Contains(x);

            int New_Ret = arrList.Add(x);

            int New_arrListCount = arrList.Count;
            int New_arrListIndexOfX = arrList.IndexOf(x);
            int New_arrListLastIndexOfX = arrList.LastIndexOf(x);

            bool New_arrListContainsX = arrList.Contains(x);
            //bool New_containsNewRet = arrList.Contains(New_Ret);

            PexObserve.ValueForViewing("$old_arrList_Count", Old_arrListCount);
            PexObserve.ValueForViewing("$new_arrList_Count", New_arrListCount);
            PexObserve.ValueForViewing("$old_arrList_x", Old_x);
            PexObserve.ValueForViewing("$old_arrList_IndexOf_x", Old_arrListIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_IndexOf_x", New_arrListIndexOfX);
            PexObserve.ValueForViewing("$old_arrList_LastIndexOf_x", Old_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_LastIndexOf_x", New_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_arrList_contains_x", Old_arrListContainsX);
            PexObserve.ValueForViewing("$new_arrList_contains_x", New_arrListContainsX);
            //PexObserve.ValueForViewing("$new_containsNewRet", New_containsNewRet);

            Assert.True(false);
        }

        // Remove x at arrList.IndexOf(x)
        // PostCondition:
        // 1. New_x == Old_x
        // 2. If (Old_arrListContainsX):
        //    (1) New_arrListCount == Old_arrListCount - 1
        //    (2) If (Old_arrListIndexOfX == Old_arrListLastIndexOfX): (!New_arrListContainsX)
        //        If (Old_arrListIndexOfX != Old_arrListLastIndexOfX): (New_arrListContainsX) && (New_arrListLastIndexOfX != Old_arrListLastIndexOfX)
        //    If (!Old_ContainsX):
        //    (1) New_arrListCount == Old_arrListCount
        //    (2) !New_ContainsX

        [PexMethod]
        public void PUT_RemoveContract([PexAssumeUnderTest]ArrayList arrList, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_arrListCount = arrList.Count;
            int Old_x = x;
            int Old_arrListIndexOfX = arrList.IndexOf(x);
            int Old_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool Old_arrListContainsX = arrList.Contains(x);

            arrList.Remove(x);

            int New_arrListCount = arrList.Count;
            int New_arrListIndexOfX = arrList.IndexOf(x);
            int New_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool New_arrListContainsX = arrList.Contains(x);

            PexObserve.ValueForViewing("$old_arrList_Count", Old_arrListCount);
            PexObserve.ValueForViewing("$new_arrList_Count", New_arrListCount);
            PexObserve.ValueForViewing("$old_arrList_x", Old_x);
            PexObserve.ValueForViewing("$old_arrList_IndexOf_x", Old_arrListIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_IndexOf_x", New_arrListIndexOfX);
            PexObserve.ValueForViewing("$old_arrList_LastIndexOf_x", Old_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_LastIndexOf_x", New_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$old_arrList_contains_x", Old_arrListContainsX);
            PexObserve.ValueForViewing("$new_arrList_contains_x", New_arrListContainsX);

            Assert.True(false);
        }

        // Insert
        // Postcondition:
        // 1. New_x == Old_x
        // 2. New_index == Old_index
        // 3. New_arrListContainsX
        // 4. New_arrListCount == Old_arrListCount + 1
        // 5. If (Old_arrListContainsX): 
        //       (index < Old_arrListIndexOfX) && (New_arrListIndexOfX == index) && (New_arrListLastIndexOfX == Old_arrListLastIndexOfX + 1)
        //       (index > Old_arrListLastIndexOfX) && (New_arrListIndexOfX == Old_arrListIndexOfX) && (New_arrListLastIndexOfX == index)
        //       (New_arrListIndexOfX == Old_arrListIndexOfX) && (New_arrListLastIndexOfX == Old_arrListLastIndexOfX + 1)
        //    If (!Old_arrListContainsX)
        //       (New_arrListIndexOfX == index) && (New_arrListLastIndexOfX == index)
        [PexMethod]
        public void PUT_InsertContract([PexAssumeUnderTest]ArrayList arrList, int x, int index)
        {
            AssumePrecondition.IsTrue(true);

            int Old_arrListCount = arrList.Count;
            int Old_x = x;
            int Old_index = index;
            int Old_arrListIndexOfX = arrList.IndexOf(x);
            int Old_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool Old_arrListContainsX = arrList.Contains(x);

            arrList.Insert(index, x);

            int New_arrListCount = arrList.Count;
            int New_arrListIndexOfX = arrList.IndexOf(x);
            int New_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool New_arrListContainsX = arrList.Contains(x);

            PexObserve.ValueForViewing("$old_arrList_Count", Old_arrListCount);
            PexObserve.ValueForViewing("$new_arrList_Count", New_arrListCount);
            PexObserve.ValueForViewing("$old_arrList_x", Old_x);
            PexObserve.ValueForViewing("$old_arrList_index", Old_index);
            PexObserve.ValueForViewing("$old_arrList_IndexOf_x", Old_arrListIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_IndexOf_x", New_arrListIndexOfX);
            PexObserve.ValueForViewing("$old_arrList_LastIndexOf_x", Old_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_LastIndexOf_x", New_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$old_arrList_contains_x", Old_arrListContainsX);
            PexObserve.ValueForViewing("$new_arrList_contains_x", New_arrListContainsX);

            Assert.True(false);

        }

        // Set
        // PostCondition:
        // 1. New_x == Old_x
        // 2. New_index == Old_index
        // 3. New_arrListContainsX
        // 4. New_arrListCount == Old_arrListCount
        // 5. If (Old_arrListContainsX): 
        //       (index < Old_arrListIndexOfX) && (New_arrListIndexOfX == index) && (New_arrListLastIndexOfX == Old_arrListLastIndexOfX + 1)
        //       (index > Old_arrListLastIndexOfX) && (New_arrListIndexOfX == Old_arrListIndexOfX) && (New_arrListLastIndexOfX == index)
        //       (New_arrListIndexOfX == Old_arrListIndexOfX) && (New_arrListLastIndexOfX == Old_arrListLastIndexOfX + 1)
        //    If (!Old_arrListContainsX)
        //       (New_arrListIndexOfX == index) && (New_arrListLastIndexOfX == index)
        [PexMethod]
        public void PUT_SetContract([PexAssumeUnderTest]ArrayList arrList, int x, int index)
        {
            AssumePrecondition.IsTrue(true);

            int Old_arrListCount = arrList.Count;
            int Old_x = x;
            int Old_index = index;
            int Old_arrListIndexOfX = arrList.IndexOf(x);
            int Old_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool Old_arrListContainsX = arrList.Contains(x);

            arrList[index] = x;

            int New_arrListCount = arrList.Count;
            int New_arrListIndexOfX = arrList.IndexOf(x);
            int New_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool New_arrListContainsX = arrList.Contains(x);

            PexObserve.ValueForViewing("$old_arrList_Count", Old_arrListCount);
            PexObserve.ValueForViewing("$new_arrList_Count", New_arrListCount);
            PexObserve.ValueForViewing("$old_arrList_x", Old_x);
            PexObserve.ValueForViewing("$old_arrList_index", Old_index);
            PexObserve.ValueForViewing("$old_arrList_IndexOf_x", Old_arrListIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_IndexOf_x", New_arrListIndexOfX);
            PexObserve.ValueForViewing("$old_arrList_LastIndexOf_x", Old_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_LastIndexOf_x", New_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$old_arrList_contains_x", Old_arrListContainsX);
            PexObserve.ValueForViewing("$new_arrList_contains_x", New_arrListContainsX);

            Assert.True(((New_arrListLastIndexOfX <= Old_arrListCount && New_arrListIndexOfX <= Old_index && Old_index <= New_arrListLastIndexOfX && Old_arrListIndexOfX <= Old_arrListLastIndexOfX && Old_arrListLastIndexOfX <= New_arrListLastIndexOfX && New_arrListCount == Old_arrListCount && (!(New_arrListLastIndexOfX == Old_arrListCount)) && New_arrListContainsX && (!(Old_arrListLastIndexOfX == Old_index)) && Old_arrListIndexOfX >= -1 && New_arrListIndexOfX >= 0) || (Old_arrListLastIndexOfX <= Old_arrListCount && Old_index <= Old_arrListLastIndexOfX && Old_arrListIndexOfX <= Old_arrListLastIndexOfX && New_arrListCount == Old_arrListCount && (!(Old_arrListLastIndexOfX == Old_arrListCount)) && New_arrListContainsX && Old_arrListContainsX && New_arrListLastIndexOfX == Old_arrListLastIndexOfX && New_arrListIndexOfX ==       Old_arrListIndexOfX +       Old_index +       -1*Old_arrListLastIndexOfX && New_arrListIndexOfX >= 0)));
        }

        [PexMethod]
        public void PUT_GetContract([PexAssumeUnderTest]ArrayList arrList, int index)
        {
            AssumePrecondition.IsTrue(true);

            int Old_arrListCount = arrList.Count;
            int Old_index = index;

            //code 
            int New_Ret = (int)(arrList[index]);

            int New_arrListCount = arrList.Count;
            bool New_containsNewRet = arrList.Contains(New_Ret);

            PexObserve.ValueForViewing("$old_arrList_Count", Old_arrListCount);
            PexObserve.ValueForViewing("$new_arrList_Count", New_arrListCount);
            PexObserve.ValueForViewing("$old_arrList_index", Old_index);
            PexObserve.ValueForViewing("$New_ret", New_Ret);

            PexObserve.ValueForViewing("$new_containsNewRet", New_containsNewRet);

            Assert.True(((Old_index <= Old_arrListCount && New_arrListCount == Old_arrListCount && (!(Old_index == Old_arrListCount)) && New_containsNewRet && Old_index >= 0)));
        }

        [PexMethod]
        public void PUT_ContainsContract([PexAssumeUnderTest]ArrayList arrList, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_arrListCount = arrList.Count;
            int Old_x = x;
            int Old_arrListIndexOfX = arrList.IndexOf(x);
            int Old_arrListLastIndexOfX = arrList.LastIndexOf(x);
            
            bool New_Ret = arrList.Contains(x);

            int New_arrListCount = arrList.Count;
            int New_arrListIndexOfX = arrList.IndexOf(x);
            int New_arrListLastIndexOfX = arrList.LastIndexOf(x);
            

            PexObserve.ValueForViewing("$old_arrList_Count", Old_arrListCount);
            PexObserve.ValueForViewing("$new_arrList_Count", New_arrListCount);
            PexObserve.ValueForViewing("$old_arrList_x", Old_x);
            PexObserve.ValueForViewing("$old_arrList_IndexOf_x", Old_arrListIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_IndexOf_x", New_arrListIndexOfX);
            PexObserve.ValueForViewing("$old_arrList_LastIndexOf_x", Old_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_LastIndexOf_x", New_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$New_ret", New_Ret);

            Assert.True(((Old_arrListCount == 0 && New_arrListCount == 0) || (New_arrListCount == Old_arrListCount && Old_arrListCount >= 1)));
        }

        [PexMethod]
        public void PUT_IndexOfContract([PexAssumeUnderTest]ArrayList arrList, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_arrListCount = arrList.Count;
            int Old_x = x;
            //int Old_arrListIndexOfX = arrList.IndexOf(x);
            int Old_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool Old_arrListContainsX = arrList.Contains(x);

            int New_Ret = arrList.IndexOf(x);

            int New_arrListCount = arrList.Count;
            //int New_arrListIndexOfX = arrList.IndexOf(x);
            int New_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool New_arrListContainsX = arrList.Contains(x);

            PexObserve.ValueForViewing("$old_arrList_Count", Old_arrListCount);
            PexObserve.ValueForViewing("$new_arrList_Count", New_arrListCount);
            PexObserve.ValueForViewing("$old_arrList_x", Old_x);
            //PexObserve.ValueForViewing("$old_arrList_IndexOf_x", Old_arrListIndexOfX);
            //PexObserve.ValueForViewing("$new_arrList_IndexOf_x", New_arrListIndexOfX);
            PexObserve.ValueForViewing("$old_arrList_LastIndexOf_x", Old_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_LastIndexOf_x", New_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_arrList_contains_x", Old_arrListContainsX);
            PexObserve.ValueForViewing("$new_arrList_contains_x", New_arrListContainsX);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_LastIndexOfContract([PexAssumeUnderTest]ArrayList arrList, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_arrListCount = arrList.Count;
            int Old_x = x;
            int Old_arrListIndexOfX = arrList.IndexOf(x);
            //int Old_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool Old_arrListContainsX = arrList.Contains(x);

            int New_Ret = arrList.LastIndexOf(x);

            int New_arrListCount = arrList.Count;
            int New_arrListIndexOfX = arrList.IndexOf(x);
            //int New_arrListLastIndexOfX = arrList.LastIndexOf(x);
            bool New_arrListContainsX = arrList.Contains(x);

            PexObserve.ValueForViewing("$old_arrList_Count", Old_arrListCount);
            PexObserve.ValueForViewing("$new_arrList_Count", New_arrListCount);
            PexObserve.ValueForViewing("$old_arrList_x", Old_x);
            PexObserve.ValueForViewing("$old_arrList_IndexOf_x", Old_arrListIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_IndexOf_x", New_arrListIndexOfX);
            //PexObserve.ValueForViewing("$old_arrList_LastIndexOf_x", Old_arrListLastIndexOfX);
            //PexObserve.ValueForViewing("$new_arrList_LastIndexOf_x", New_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_arrList_contains_x", Old_arrListContainsX);
            PexObserve.ValueForViewing("$new_arrList_contains_x", New_arrListContainsX);

            Assert.True(false);
        }

        [PexMethod]
        public void PUT_CountContract([PexAssumeUnderTest]ArrayList arrList)
        {
            AssumePrecondition.IsTrue(true);

            //int Old_arrListCount = arrList.Count;

            int New_Ret = arrList.Count;

            //int New_arrListCount = arrList.Count;
            //bool New_containsNewRet = arrList.Contains(New_Ret);

            //PexObserve.ValueForViewing("$old_arrList_Count", Old_arrListCount);
            //PexObserve.ValueForViewing("$new_arrList_Count", New_arrListCount);
            PexObserve.ValueForViewing("$New_ret", New_Ret);

            //PexObserve.ValueForViewing("$new_containsNewRet", New_containsNewRet);

            Assert.True(false);
        }
    }
}