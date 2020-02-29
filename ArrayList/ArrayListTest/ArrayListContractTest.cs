using System;
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

            Assert.True(((New_arrListContainsX && New_arrListCount == Old_arrListCount + 1 && New_arrListLastIndexOfX == Old_arrListCount && New_Ret == Old_arrListCount && New_arrListCount != Old_arrListCount && Old_arrListIndexOfX != New_arrListCount && New_arrListIndexOfX != New_arrListCount && Old_arrListLastIndexOfX != New_arrListCount && New_arrListLastIndexOfX != New_arrListCount && New_Ret != New_arrListCount && New_arrListLastIndexOfX != Old_arrListIndexOfX && New_Ret != Old_arrListIndexOfX && New_arrListLastIndexOfX != Old_arrListLastIndexOfX && New_Ret != Old_arrListLastIndexOfX && New_Ret == New_arrListLastIndexOfX && New_arrListIndexOfX <= Old_arrListCount && New_arrListLastIndexOfX <= Old_arrListCount && New_Ret <= Old_arrListCount && Old_arrListIndexOfX < New_arrListCount && Old_arrListIndexOfX <= New_arrListCount && New_arrListIndexOfX < New_arrListCount && New_arrListIndexOfX <= New_arrListCount && Old_arrListLastIndexOfX < New_arrListCount && Old_arrListLastIndexOfX <= New_arrListCount && New_arrListLastIndexOfX < New_arrListCount && New_arrListLastIndexOfX <= New_arrListCount && New_Ret < New_arrListCount && New_Ret <= New_arrListCount && New_Ret <= New_arrListLastIndexOfX && 0 <= Old_arrListCount && -1 < Old_arrListCount && -1 <= Old_arrListCount && 1 <= New_arrListCount && 0 < New_arrListCount && 0 <= New_arrListCount && -1 < New_arrListCount && -1 <= New_arrListCount && -1 <= Old_arrListIndexOfX && 0 <= New_arrListIndexOfX && -1 < New_arrListIndexOfX && -1 <= New_arrListIndexOfX && -1 <= Old_arrListLastIndexOfX && 0 <= New_arrListLastIndexOfX && -1 < New_arrListLastIndexOfX && -1 <= New_arrListLastIndexOfX && 0 <= New_Ret && -1 < New_Ret && -1 <= New_Ret) && (((New_arrListIndexOfX == Old_arrListIndexOfX && New_arrListIndexOfX != Old_arrListCount && New_arrListLastIndexOfX !=               New_arrListIndexOfX && New_Ret != New_arrListIndexOfX && New_arrListIndexOfX < Old_arrListCount && New_arrListIndexOfX <= Old_arrListIndexOfX && 1 <= Old_arrListCount && 0 < Old_arrListCount && 1 < New_arrListCount && 0 <= Old_arrListIndexOfX && -1 < Old_arrListIndexOfX && 0 <= Old_arrListLastIndexOfX && -1 < Old_arrListLastIndexOfX && 1 <= New_arrListLastIndexOfX && 0 < New_arrListLastIndexOfX && 1 <= New_Ret && 0 < New_Ret) && Old_arrListContainsX) || ((New_arrListIndexOfX == Old_arrListCount && New_arrListIndexOfX != Old_arrListIndexOfX && Old_arrListLastIndexOfX !=               New_arrListIndexOfX && New_arrListLastIndexOfX ==               New_arrListIndexOfX && New_Ret == New_arrListIndexOfX && Old_arrListLastIndexOfX < New_arrListIndexOfX && Old_arrListLastIndexOfX <=               New_arrListIndexOfX && New_arrListLastIndexOfX <=               New_arrListIndexOfX && New_Ret <= New_arrListIndexOfX && -1 == Old_arrListIndexOfX && -1 == Old_arrListLastIndexOfX) && (!(Old_arrListContainsX))))));
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

            Assert.True(((New_arrListLastIndexOfX ==        Old_arrListLastIndexOfX - Old_arrListIndexOfX - 1 && New_arrListIndexOfX != Old_arrListCount && New_arrListLastIndexOfX != Old_arrListCount && New_arrListIndexOfX != New_arrListCount && New_arrListLastIndexOfX != New_arrListCount && New_arrListCount <= Old_arrListCount && New_arrListIndexOfX < Old_arrListCount && New_arrListIndexOfX <= Old_arrListCount && New_arrListLastIndexOfX < Old_arrListCount && New_arrListLastIndexOfX <= Old_arrListCount && Old_arrListIndexOfX <= New_arrListCount && New_arrListIndexOfX < New_arrListCount && New_arrListIndexOfX <= New_arrListCount && Old_arrListLastIndexOfX <= New_arrListCount && New_arrListLastIndexOfX < New_arrListCount && New_arrListLastIndexOfX <= New_arrListCount && New_arrListLastIndexOfX <= Old_arrListLastIndexOfX && 0 <= Old_arrListCount && -1 < Old_arrListCount && -1 <= Old_arrListCount && 0 <= New_arrListCount && -1 < New_arrListCount && -1 <= New_arrListCount && -1 <= Old_arrListIndexOfX && -1 <= New_arrListIndexOfX && -1 <= Old_arrListLastIndexOfX && -1 <= New_arrListLastIndexOfX) && (((New_arrListCount == Old_arrListCount - 1 && New_arrListCount != Old_arrListCount && Old_arrListLastIndexOfX !=               New_arrListIndexOfX && New_arrListLastIndexOfX !=               Old_arrListLastIndexOfX && New_arrListCount < Old_arrListCount && New_arrListLastIndexOfX <               Old_arrListLastIndexOfX && 1 <= Old_arrListCount && 0 < Old_arrListCount && 0 <= Old_arrListIndexOfX && -1 < Old_arrListIndexOfX && 0 <= Old_arrListLastIndexOfX && -1 < Old_arrListLastIndexOfX) && Old_arrListContainsX) || ((New_arrListCount == Old_arrListCount && New_arrListIndexOfX == Old_arrListIndexOfX && New_arrListLastIndexOfX ==               Old_arrListIndexOfX && (!(New_arrListContainsX)) && Old_arrListIndexOfX != New_arrListCount && Old_arrListLastIndexOfX != New_arrListCount && Old_arrListLastIndexOfX ==               New_arrListIndexOfX && New_arrListLastIndexOfX ==               New_arrListIndexOfX && New_arrListLastIndexOfX ==               Old_arrListLastIndexOfX && Old_arrListIndexOfX < New_arrListCount && Old_arrListLastIndexOfX < New_arrListCount && New_arrListIndexOfX <= Old_arrListIndexOfX && New_arrListLastIndexOfX <=               Old_arrListIndexOfX && Old_arrListLastIndexOfX <=               New_arrListIndexOfX && New_arrListLastIndexOfX <=               New_arrListIndexOfX && -1 == Old_arrListIndexOfX && -1 == New_arrListIndexOfX && -1 == Old_arrListLastIndexOfX && -1 == New_arrListLastIndexOfX) && (!(Old_arrListContainsX))))));
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
            AssumePrecondition.IsTrue(index <= arrList.Count && index >= 0);

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

            Assert.True(((New_arrListContainsX && New_arrListCount == Old_arrListCount + 1 && New_arrListCount != Old_arrListCount && Old_index != New_arrListCount && Old_arrListIndexOfX != New_arrListCount && New_arrListIndexOfX != New_arrListCount && Old_arrListLastIndexOfX != New_arrListCount && New_arrListLastIndexOfX != New_arrListCount && New_arrListLastIndexOfX != Old_arrListIndexOfX && New_arrListLastIndexOfX != Old_arrListLastIndexOfX && New_arrListIndexOfX <= Old_arrListCount && New_arrListLastIndexOfX <= Old_arrListCount && Old_index < New_arrListCount && Old_index <= New_arrListCount && Old_arrListIndexOfX < New_arrListCount && Old_arrListIndexOfX <= New_arrListCount && New_arrListIndexOfX < New_arrListCount && New_arrListIndexOfX <= New_arrListCount && Old_arrListLastIndexOfX < New_arrListCount && Old_arrListLastIndexOfX <= New_arrListCount && New_arrListLastIndexOfX < New_arrListCount && New_arrListLastIndexOfX <= New_arrListCount && New_arrListIndexOfX <= Old_index && 0 <= Old_arrListCount && -1 < Old_arrListCount && -1 <= Old_arrListCount && 1 <= New_arrListCount && 0 < New_arrListCount && 0 <= New_arrListCount && -1 < New_arrListCount && -1 <= New_arrListCount && 0 <= Old_index && -1 < Old_index && -1 <= Old_index && -1 <= Old_arrListIndexOfX && 0 <= New_arrListIndexOfX && -1 < New_arrListIndexOfX && -1 <= New_arrListIndexOfX && -1 <= Old_arrListLastIndexOfX && 0 <= New_arrListLastIndexOfX && -1 < New_arrListLastIndexOfX && -1 <= New_arrListLastIndexOfX) && (((New_arrListIndexOfX != Old_arrListCount && New_arrListLastIndexOfX !=               New_arrListIndexOfX && New_arrListIndexOfX < Old_arrListCount && New_arrListIndexOfX <= Old_arrListIndexOfX && 1 <= Old_arrListCount && 0 < Old_arrListCount && 1 < New_arrListCount && 0 <= Old_arrListIndexOfX && -1 < Old_arrListIndexOfX && 0 <= Old_arrListLastIndexOfX && -1 < Old_arrListLastIndexOfX && 1 <= New_arrListLastIndexOfX && 0 < New_arrListLastIndexOfX) && Old_arrListContainsX) || ((New_arrListIndexOfX == Old_index && New_arrListLastIndexOfX == Old_index && New_arrListIndexOfX != Old_arrListIndexOfX && Old_arrListLastIndexOfX !=               New_arrListIndexOfX && New_arrListLastIndexOfX ==               New_arrListIndexOfX && New_arrListLastIndexOfX <= Old_index && Old_arrListLastIndexOfX < New_arrListIndexOfX && Old_arrListLastIndexOfX <=               New_arrListIndexOfX && New_arrListLastIndexOfX <=               New_arrListIndexOfX && -1 == Old_arrListIndexOfX && -1 == Old_arrListLastIndexOfX) && (!(Old_arrListContainsX))))));
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
            AssumePrecondition.IsTrue(index >= 0 && index < arrList.Count);

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

            Assert.True(((New_arrListContainsX && New_arrListCount == Old_arrListCount && New_arrListIndexOfX != Old_arrListCount && New_arrListLastIndexOfX != Old_arrListCount && Old_index != New_arrListCount && Old_arrListIndexOfX != New_arrListCount && New_arrListIndexOfX != New_arrListCount && Old_arrListLastIndexOfX != New_arrListCount && New_arrListLastIndexOfX != New_arrListCount && New_arrListCount <= Old_arrListCount && New_arrListIndexOfX < Old_arrListCount && New_arrListIndexOfX <= Old_arrListCount && New_arrListLastIndexOfX < Old_arrListCount && New_arrListLastIndexOfX <= Old_arrListCount && Old_index < New_arrListCount && Old_index <= New_arrListCount && Old_arrListIndexOfX < New_arrListCount && Old_arrListIndexOfX <= New_arrListCount && New_arrListIndexOfX < New_arrListCount && New_arrListIndexOfX <= New_arrListCount && Old_arrListLastIndexOfX < New_arrListCount && Old_arrListLastIndexOfX <= New_arrListCount && New_arrListLastIndexOfX < New_arrListCount && New_arrListLastIndexOfX <= New_arrListCount && New_arrListIndexOfX <= Old_index && 1 <= Old_arrListCount && 0 < Old_arrListCount && 0 <= Old_arrListCount && -1 < Old_arrListCount && -1 <= Old_arrListCount && 1 <= New_arrListCount && 0 < New_arrListCount && 0 <= New_arrListCount && -1 < New_arrListCount && -1 <= New_arrListCount && 0 <= Old_index && -1 < Old_index && -1 <= Old_index && -1 <= Old_arrListIndexOfX && 0 <= New_arrListIndexOfX && -1 < New_arrListIndexOfX && -1 <= New_arrListIndexOfX && -1 <= Old_arrListLastIndexOfX && 0 <= New_arrListLastIndexOfX && -1 < New_arrListLastIndexOfX && -1 <= New_arrListLastIndexOfX) && (((New_arrListIndexOfX <= Old_arrListIndexOfX && 0 <= Old_arrListIndexOfX && -1 < Old_arrListIndexOfX && 0 <= Old_arrListLastIndexOfX && -1 < Old_arrListLastIndexOfX) && Old_arrListContainsX) || ((New_arrListIndexOfX == Old_index && New_arrListLastIndexOfX == Old_index && New_arrListIndexOfX != Old_arrListIndexOfX && New_arrListLastIndexOfX !=               Old_arrListIndexOfX && Old_arrListLastIndexOfX !=               New_arrListIndexOfX && New_arrListLastIndexOfX ==               New_arrListIndexOfX && New_arrListLastIndexOfX !=               Old_arrListLastIndexOfX && New_arrListLastIndexOfX <= Old_index && Old_arrListLastIndexOfX < New_arrListIndexOfX && Old_arrListLastIndexOfX <=               New_arrListIndexOfX && New_arrListLastIndexOfX <=               New_arrListIndexOfX && -1 == Old_arrListIndexOfX && -1 == Old_arrListLastIndexOfX) && (!(Old_arrListContainsX))))));
        }

        [PexMethod]
        public void PUT_GetContract([PexAssumeUnderTest]ArrayList arrList, int index)
        {
            AssumePrecondition.IsTrue(index < arrList.Count && index >= 0);

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

            Assert.True((New_containsNewRet && New_arrListCount == Old_arrListCount && Old_index != New_arrListCount && New_arrListCount <= Old_arrListCount && Old_index < New_arrListCount && Old_index <= New_arrListCount && 1 <= Old_arrListCount && 0 < Old_arrListCount && 0 <= Old_arrListCount && -1 < Old_arrListCount && -1 <= Old_arrListCount && 1 <= New_arrListCount && 0 < New_arrListCount && 0 <= New_arrListCount && -1 < New_arrListCount && -1 <= New_arrListCount && 0 <= Old_index && -1 < Old_index && -1 <= Old_index));
        }

        [PexMethod]
        public void PUT_ContainsContract([PexAssumeUnderTest]ArrayList arrList, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_arrListCount = arrList.Count;
            int Old_x = x;
            int Old_arrListIndexOfX = arrList.IndexOf(x);
            int Old_arrListLastIndexOfX = arrList.LastIndexOf(x);
            //bool Old_arrListContainsX = arrList.Contains(x);

            bool New_Ret = arrList.Contains(x);

            int New_arrListCount = arrList.Count;
            int New_arrListIndexOfX = arrList.IndexOf(x);
            int New_arrListLastIndexOfX = arrList.LastIndexOf(x);
            //bool New_arrListContainsX = arrList.Contains(x);

            PexObserve.ValueForViewing("$old_arrList_Count", Old_arrListCount);
            PexObserve.ValueForViewing("$new_arrList_Count", New_arrListCount);
            PexObserve.ValueForViewing("$old_arrList_x", Old_x);
            PexObserve.ValueForViewing("$old_arrList_IndexOf_x", Old_arrListIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_IndexOf_x", New_arrListIndexOfX);
            PexObserve.ValueForViewing("$old_arrList_LastIndexOf_x", Old_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$new_arrList_LastIndexOf_x", New_arrListLastIndexOfX);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            //PexObserve.ValueForViewing("$old_arrList_contains_x", Old_arrListContainsX);
            //PexObserve.ValueForViewing("$new_arrList_contains_x", New_arrListContainsX);

            Assert.True(((New_arrListCount == Old_arrListCount && New_arrListIndexOfX == Old_arrListIndexOfX && New_arrListLastIndexOfX == Old_arrListLastIndexOfX && New_arrListIndexOfX != Old_arrListCount && New_arrListLastIndexOfX != Old_arrListCount && Old_arrListIndexOfX != New_arrListCount && New_arrListIndexOfX != New_arrListCount && Old_arrListLastIndexOfX != New_arrListCount && New_arrListLastIndexOfX != New_arrListCount && New_arrListCount <= Old_arrListCount && New_arrListIndexOfX < Old_arrListCount && New_arrListIndexOfX <= Old_arrListCount && New_arrListLastIndexOfX < Old_arrListCount && New_arrListLastIndexOfX <= Old_arrListCount && Old_arrListIndexOfX < New_arrListCount && Old_arrListIndexOfX <= New_arrListCount && New_arrListIndexOfX < New_arrListCount && New_arrListIndexOfX <= New_arrListCount && Old_arrListLastIndexOfX < New_arrListCount && Old_arrListLastIndexOfX <= New_arrListCount && New_arrListLastIndexOfX < New_arrListCount && New_arrListLastIndexOfX <= New_arrListCount && New_arrListIndexOfX <= Old_arrListIndexOfX && New_arrListLastIndexOfX <= Old_arrListLastIndexOfX && 0 <= Old_arrListCount && -1 < Old_arrListCount && -1 <= Old_arrListCount && 0 <= New_arrListCount && -1 < New_arrListCount && -1 <= New_arrListCount && -1 <= Old_arrListIndexOfX && -1 <= New_arrListIndexOfX && -1 <= Old_arrListLastIndexOfX && -1 <= New_arrListLastIndexOfX) && (((1 <= Old_arrListCount && 0 < Old_arrListCount && 1 <= New_arrListCount && 0 < New_arrListCount && 0 <= Old_arrListIndexOfX && -1 < Old_arrListIndexOfX && 0 <= New_arrListIndexOfX && -1 < New_arrListIndexOfX && 0 <= Old_arrListLastIndexOfX && -1 < Old_arrListLastIndexOfX && 0 <= New_arrListLastIndexOfX && -1 < New_arrListLastIndexOfX) && New_Ret) || ((New_arrListLastIndexOfX ==               Old_arrListIndexOfX && Old_arrListLastIndexOfX ==               New_arrListIndexOfX && New_arrListLastIndexOfX ==               New_arrListIndexOfX && New_arrListLastIndexOfX <=               Old_arrListIndexOfX && Old_arrListLastIndexOfX <=               New_arrListIndexOfX && New_arrListLastIndexOfX <=               New_arrListIndexOfX && -1 == Old_arrListIndexOfX && -1 == New_arrListIndexOfX && -1 == Old_arrListLastIndexOfX && -1 == New_arrListLastIndexOfX) && (!(New_Ret))))));
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

            Assert.True(((New_arrListCount == Old_arrListCount && New_arrListLastIndexOfX == Old_arrListLastIndexOfX && New_arrListLastIndexOfX != Old_arrListCount && New_Ret != Old_arrListCount && Old_arrListLastIndexOfX != New_arrListCount && New_arrListLastIndexOfX != New_arrListCount && New_Ret != New_arrListCount && New_arrListCount <= Old_arrListCount && New_arrListLastIndexOfX < Old_arrListCount && New_arrListLastIndexOfX <= Old_arrListCount && New_Ret < Old_arrListCount && New_Ret <= Old_arrListCount && Old_arrListLastIndexOfX < New_arrListCount && Old_arrListLastIndexOfX <= New_arrListCount && New_arrListLastIndexOfX < New_arrListCount && New_arrListLastIndexOfX <= New_arrListCount && New_Ret < New_arrListCount && New_Ret <= New_arrListCount && New_arrListLastIndexOfX <= Old_arrListLastIndexOfX && New_Ret <= Old_arrListLastIndexOfX && New_Ret <= New_arrListLastIndexOfX && 0 <= Old_arrListCount && -1 < Old_arrListCount && -1 <= Old_arrListCount && 0 <= New_arrListCount && -1 < New_arrListCount && -1 <= New_arrListCount && -1 <= Old_arrListLastIndexOfX && -1 <= New_arrListLastIndexOfX && -1 <= New_Ret) && (((Old_arrListContainsX && 1 <= Old_arrListCount && 0 < Old_arrListCount && 1 <= New_arrListCount && 0 < New_arrListCount && 0 <= Old_arrListLastIndexOfX && -1 < Old_arrListLastIndexOfX && 0 <= New_arrListLastIndexOfX && -1 < New_arrListLastIndexOfX && 0 <= New_Ret && -1 < New_Ret) && New_arrListContainsX) || ((New_Ret == Old_arrListLastIndexOfX && (!(Old_arrListContainsX)) && New_Ret == New_arrListLastIndexOfX && -1 == Old_arrListLastIndexOfX && -1 == New_arrListLastIndexOfX && -1 == New_Ret) && (!(New_arrListContainsX))))));
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

            Assert.True(((New_arrListCount == Old_arrListCount && New_arrListIndexOfX == Old_arrListIndexOfX && New_arrListIndexOfX != Old_arrListCount && New_Ret != Old_arrListCount && Old_arrListIndexOfX != New_arrListCount && New_arrListIndexOfX != New_arrListCount && New_Ret != New_arrListCount && New_arrListCount <= Old_arrListCount && New_arrListIndexOfX < Old_arrListCount && New_arrListIndexOfX <= Old_arrListCount && New_Ret < Old_arrListCount && New_Ret <= Old_arrListCount && Old_arrListIndexOfX < New_arrListCount && Old_arrListIndexOfX <= New_arrListCount && New_arrListIndexOfX < New_arrListCount && New_arrListIndexOfX <= New_arrListCount && New_Ret < New_arrListCount && New_Ret <= New_arrListCount && New_arrListIndexOfX <= Old_arrListIndexOfX && 0 <= Old_arrListCount && -1 < Old_arrListCount && -1 <= Old_arrListCount && 0 <= New_arrListCount && -1 < New_arrListCount && -1 <= New_arrListCount && -1 <= Old_arrListIndexOfX && -1 <= New_arrListIndexOfX && -1 <= New_Ret) && (((Old_arrListContainsX && 1 <= Old_arrListCount && 0 < Old_arrListCount && 1 <= New_arrListCount && 0 < New_arrListCount && 0 <= Old_arrListIndexOfX && -1 < Old_arrListIndexOfX && 0 <= New_arrListIndexOfX && -1 < New_arrListIndexOfX && 0 <= New_Ret && -1 < New_Ret) && New_arrListContainsX) || ((New_Ret == Old_arrListIndexOfX && (!(Old_arrListContainsX)) && New_Ret == New_arrListIndexOfX && New_Ret <= Old_arrListIndexOfX && New_Ret <= New_arrListIndexOfX && -1 == Old_arrListIndexOfX && -1 == New_arrListIndexOfX && -1 == New_Ret) && (!(New_arrListContainsX))))));
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