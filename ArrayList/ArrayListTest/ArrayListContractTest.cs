using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayList;
using PexAPIWrapper;

namespace ArrayList.Test
{
    [TestClass, PexClass]
    public partial class ArrayListContractTest
    {
        // Add x to the end of arraylist
        // PostCondition:
        // 1. New_alContainsX
        // 2. New_alCount == Old_alCount + 1
        // 3. New_alLastIndexOfX != Old_alLastIndexOfX 
        // 4. New_alLastIndexOfX == New_alCount - 1
        // 5. New_x == Old_x 
        // 6. New_Ret == Old_alCount 
        // 7. if (Old_alContainsX): (New_alIndexOfX != New_alLastIndexOfX) && (New_alIndexOfX == Old_alIndexOfX)
        //    if (!Old_alContainsX): (New_alIndexOfX == New_alLastIndexOfX) && (New_alIndexOfX != Old_alIndexOfX)

        [PexMethod]
        public void PUT_AddContract([PexAssumeUnderTest]ArrayList al, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_alCount = al.Count;
            int Old_x = x;
            int Old_Ret = PexChoose.Value<int>("old_Ret");
            int Old_alIndexOfX = al.IndexOf(x);
            int Old_alLastIndexOfX = al.LastIndexOf(x);
            bool Old_alContainsX = al.Contains(x);

            int New_Ret = al.Add(x);

            int New_alCount = al.Count;
            int New_x = x;
            int New_alIndexOfX = al.IndexOf(x);
            int New_alLastIndexOfX = al.LastIndexOf(x);
            bool New_alContainsX = al.Contains(x);

            PexObserve.ValueForViewing("$old_al_Count", Old_alCount);
            PexObserve.ValueForViewing("$new_al_Count", New_alCount);
            PexObserve.ValueForViewing("$old_al_x", Old_x);
            PexObserve.ValueForViewing("$new_al_x", New_x);
            PexObserve.ValueForViewing("$old_al_IndexOf_x", Old_alIndexOfX);
            PexObserve.ValueForViewing("$new_al_IndexOf_x", New_alIndexOfX);
            PexObserve.ValueForViewing("$old_al_LastIndexOf_x", Old_alLastIndexOfX);
            PexObserve.ValueForViewing("$new_al_LastIndexOf_x", New_alLastIndexOfX);
            PexObserve.ValueForViewing("$Old_ret", Old_Ret);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_al_contains_x", Old_alContainsX);
            PexObserve.ValueForViewing("$new_al_contains_x", New_alContainsX);

            PexAssert.IsTrue(((New_alContainsX) && ( ! (New_alCount == Old_alIndexOfX)) && ( ! (New_alCount == New_alIndexOfX)) && ( ! (New_alCount == Old_alLastIndexOfX)) 
                && ( ! (Old_alIndexOfX == New_Ret)) && ( ! (Old_alLastIndexOfX == New_Ret)) && (New_alLastIndexOfX == Old_alCount) && (New_x == Old_x) && (New_alCount == 1 + Old_alCount) 
                && (New_Ret == Old_alCount)));
        }

        // Remove x at al.IndexOf(x)
        // PostCondition:
        // 1. New_x == Old_x
        // 2. If (Old_alContainsX):
        //    (1) New_alCount == Old_alCount - 1
        //    (2) If (Old_alIndexOfX == Old_alLastIndexOfX): (!New_alContainsX)
        //        If (Old_alIndexOfX != Old_alLastIndexOfX): (New_alContainsX) && (New_alLastIndexOfX != Old_alLastIndexOfX)
        //    If (!Old_ContainsX):
        //    (1) New_alCount == Old_alCount
        //    (2) !New_ContainsX
        
        [PexMethod]
        public void PUT_RemoveContract([PexAssumeUnderTest]ArrayList al, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_alCount = al.Count;
            int Old_x = x;
            int Old_alIndexOfX = al.IndexOf(x);
            int Old_alLastIndexOfX = al.LastIndexOf(x);
            bool Old_alContainsX = al.Contains(x);

            al.Remove(x);

            int New_alCount = al.Count;
            int New_x = x;
            int New_alIndexOfX = al.IndexOf(x);
            int New_alLastIndexOfX = al.LastIndexOf(x);
            bool New_alContainsX = al.Contains(x);

            PexObserve.ValueForViewing("$old_al_Count", Old_alCount);
            PexObserve.ValueForViewing("$new_al_Count", New_alCount);
            PexObserve.ValueForViewing("$old_al_x", Old_x);
            PexObserve.ValueForViewing("$new_al_x", New_x);
            PexObserve.ValueForViewing("$old_al_IndexOf_x", Old_alIndexOfX);
            PexObserve.ValueForViewing("$new_al_IndexOf_x", New_alIndexOfX);
            PexObserve.ValueForViewing("$old_al_LastIndexOf_x", Old_alLastIndexOfX);
            PexObserve.ValueForViewing("$new_al_LastIndexOf_x", New_alLastIndexOfX);
            PexObserve.ValueForViewing("$old_al_contains_x", Old_alContainsX);
            PexObserve.ValueForViewing("$new_al_contains_x", New_alContainsX);

            PexAssert.IsTrue((( ! (New_alCount == New_alLastIndexOfX)) && (Old_x == New_x) && (New_alLastIndexOfX ==  -1 + Old_alLastIndexOfX + -1*Old_alIndexOfX) && (New_x == 0) && (New_alCount == -1 + Old_alCount + -1*Old_alIndexOfX) && (New_alIndexOfX ==  -1 + Old_alLastIndexOfX + -1*Old_alIndexOfX) && (Old_alIndexOfX == New_alIndexOfX) && (Old_alLastIndexOfX == New_alLastIndexOfX)) || (( ! (Old_alCount == Old_alIndexOfX)) && ( ! (Old_alCount == New_alLastIndexOfX)) && ( ! (New_alCount == New_alLastIndexOfX)) && (Old_x == New_x) && (New_alLastIndexOfX ==  -1 + Old_alLastIndexOfX + -1*Old_alIndexOfX) && (New_x == 0) && (New_alCount == -1 + Old_alCount + -1*Old_alIndexOfX) && (New_alIndexOfX ==  -1 + Old_alLastIndexOfX + -1*Old_alIndexOfX) && ( ! (Old_alCount == Old_x))));
        }

        // Insert
        // Postcondition:
        // 1. New_x == Old_x
        // 2. New_index == Old_index
        // 3. New_alContainsX
        // 4. New_alCount == Old_alCount + 1
        // 5. If (Old_alContainsX): 
        //       (index < Old_alIndexOfX) && (New_alIndexOfX == index) && (New_alLastIndexOfX == Old_alLastIndexOfX + 1)
        //       (index > Old_alLastIndexOfX) && (New_alIndexOfX == Old_alIndexOfX) && (New_alLastIndexOfX == index)
        //       (New_alIndexOfX == Old_alIndexOfX) && (New_alLastIndexOfX == Old_alLastIndexOfX + 1)
        //    If (!Old_alContainsX)
        //       (New_alIndexOfX == index) && (New_alLastIndexOfX == index)
        [PexMethod]
        public void PUT_InsertContract([PexAssumeUnderTest]ArrayList al, int x, int index)
        {
            AssumePrecondition.IsTrue(index <= al.Count && index >= 0);

            int Old_alCount = al.Count;
            int Old_x = x;
            int Old_index = index;
            int Old_alIndexOfX = al.IndexOf(x);
            int Old_alLastIndexOfX = al.LastIndexOf(x);
            bool Old_alContainsX = al.Contains(x);

            al.Insert(index, x);

            int New_alCount = al.Count;
            int New_x = x;
            int New_index = index;
            int New_alIndexOfX = al.IndexOf(x);
            int New_alLastIndexOfX = al.LastIndexOf(x);
            bool New_alContainsX = al.Contains(x);

            PexObserve.ValueForViewing("$old_al_Count", Old_alCount);
            PexObserve.ValueForViewing("$new_al_Count", New_alCount);
            PexObserve.ValueForViewing("$old_al_x", Old_x);
            PexObserve.ValueForViewing("$new_al_x", New_x);
            PexObserve.ValueForViewing("$old_al_index", Old_index);
            PexObserve.ValueForViewing("$new_al_index", New_index);
            PexObserve.ValueForViewing("$old_al_IndexOf_x", Old_alIndexOfX);
            PexObserve.ValueForViewing("$new_al_IndexOf_x", New_alIndexOfX);
            PexObserve.ValueForViewing("$old_al_LastIndexOf_x", Old_alLastIndexOfX);
            PexObserve.ValueForViewing("$new_al_LastIndexOf_x", New_alLastIndexOfX);
            PexObserve.ValueForViewing("$old_al_contains_x", Old_alContainsX);
            PexObserve.ValueForViewing("$new_al_contains_x", New_alContainsX);

            PexAssert.IsTrue(((New_alContainsX) && ( ! (New_alCount == New_alIndexOfX)) && ( ! (New_alCount == Old_alLastIndexOfX)) && ( ! (Old_alLastIndexOfX == New_alLastIndexOfX)) && (New_x == Old_x) && (New_alCount == 1 + Old_alCount) && (New_index == Old_index) && (Old_alIndexOfX == Old_alLastIndexOfX) && (New_index == New_alIndexOfX) && (Old_alCount == New_alLastIndexOfX)) || ((New_alContainsX) && ( ! (Old_alCount == Old_alIndexOfX)) && ( ! (Old_alCount == Old_alLastIndexOfX)) && ( ! (New_alCount == New_index)) && ( ! (New_alCount == Old_alIndexOfX)) && ( ! (New_alCount == New_alIndexOfX)) && ( ! (New_alCount == Old_alLastIndexOfX)) && ( ! (New_alCount == New_alLastIndexOfX)) && ( ! (Old_alIndexOfX == New_alLastIndexOfX)) && ( ! (Old_alLastIndexOfX == New_alLastIndexOfX)) && (New_x == Old_x) && (New_alCount == 1 + Old_alCount) && (New_index == Old_index) && ( ! (Old_alCount == New_alIndexOfX))));
        }

        // Set
        // PostCondition:
        // 1. New_x == Old_x
        // 2. New_index == Old_index
        // 3. New_alContainsX
        // 4. New_alCount == Old_alCount
        // 5. If (Old_alContainsX): 
        //       (index < Old_alIndexOfX) && (New_alIndexOfX == index) && (New_alLastIndexOfX == Old_alLastIndexOfX + 1)
        //       (index > Old_alLastIndexOfX) && (New_alIndexOfX == Old_alIndexOfX) && (New_alLastIndexOfX == index)
        //       (New_alIndexOfX == Old_alIndexOfX) && (New_alLastIndexOfX == Old_alLastIndexOfX + 1)
        //    If (!Old_alContainsX)
        //       (New_alIndexOfX == index) && (New_alLastIndexOfX == index)
        [PexMethod]
        public void PUT_SetContract([PexAssumeUnderTest]ArrayList al, int x, int index)
        {
            AssumePrecondition.IsTrue(index < al.Count && index >= 0);

            int Old_alCount = al.Count;
            int Old_x = x;
            int Old_index = index;
            int Old_alIndexOfX = al.IndexOf(x);
            int Old_alLastIndexOfX = al.LastIndexOf(x);
            bool Old_alContainsX = al.Contains(x);

            al[index] = x;

            int New_alCount = al.Count;
            int New_x = x;
            int New_index = index;
            int New_alIndexOfX = al.IndexOf(x);
            int New_alLastIndexOfX = al.LastIndexOf(x);
            bool New_alContainsX = al.Contains(x);

            PexObserve.ValueForViewing("$old_al_Count", Old_alCount);
            PexObserve.ValueForViewing("$new_al_Count", New_alCount);
            PexObserve.ValueForViewing("$old_al_x", Old_x);
            PexObserve.ValueForViewing("$new_al_x", New_x);
            PexObserve.ValueForViewing("$old_al_index", Old_index);
            PexObserve.ValueForViewing("$new_al_index", New_index);
            PexObserve.ValueForViewing("$old_al_IndexOf_x", Old_alIndexOfX);
            PexObserve.ValueForViewing("$new_al_IndexOf_x", New_alIndexOfX);
            PexObserve.ValueForViewing("$old_al_LastIndexOf_x", Old_alLastIndexOfX);
            PexObserve.ValueForViewing("$new_al_LastIndexOf_x", New_alLastIndexOfX);
            PexObserve.ValueForViewing("$old_al_contains_x", Old_alContainsX);
            PexObserve.ValueForViewing("$new_al_contains_x", New_alContainsX);

            PexAssert.IsTrue(((New_alContainsX) && ( ! (New_alCount == New_index)) && ( ! (New_alCount == Old_alIndexOfX)) && ( ! (New_alCount == New_alIndexOfX)) && ( ! (New_alCount == Old_alLastIndexOfX)) && ( ! (New_alCount == New_alLastIndexOfX)) && (New_x == Old_x) && (New_alCount == Old_alCount) && (New_index == Old_index) && (Old_alContainsX)) || ((New_alContainsX) && ( ! (New_alCount == Old_alLastIndexOfX)) && ( ! (New_alCount == New_alLastIndexOfX)) && (New_x == Old_x) && (New_alCount == Old_alCount) && (New_index == Old_index) && (Old_alIndexOfX == Old_alLastIndexOfX) && (New_index == New_alIndexOfX) && (New_alIndexOfX == New_alLastIndexOfX) && ( ! (New_index == Old_alLastIndexOfX))));
        }

        [PexMethod]
        public void PUT_GetContract([PexAssumeUnderTest]ArrayList al, int index)
        {
            AssumePrecondition.IsTrue(index < al.Count && index >= 0);

            int Old_alCount = al.Count;
            int Old_Ret = 2;
            int Old_index = index;

            int New_Ret = (int)(al[index]);

            int New_alCount = al.Count;
            int New_index = index;


            PexObserve.ValueForViewing("$old_al_Count", Old_alCount);
            PexObserve.ValueForViewing("$new_al_Count", New_alCount);
            PexObserve.ValueForViewing("$old_al_index", Old_index);
            PexObserve.ValueForViewing("$new_al_index", New_index);
            PexObserve.ValueForViewing("$Old_ret", Old_Ret);
            PexObserve.ValueForViewing("$New_ret", New_Ret);

            PexAssert.IsTrue((( ! (New_alCount == New_index)) && (New_index == Old_index) && (New_alCount == Old_alCount) && ( ! (Old_index == New_Ret))) || (( ! (New_alCount == New_index)) && (New_index == Old_index) && (New_alCount == Old_alCount) && ( ! (Old_Ret == New_Ret))));
        }

        [PexMethod]
        public void PUT_ContainsContract([PexAssumeUnderTest]ArrayList al, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_alCount = al.Count;
            int Old_x = x;
            bool Old_Ret = PexChoose.Value<bool>("default_Ret");
            int Old_alIndexOfX = al.IndexOf(x);
            int Old_alLastIndexOfX = al.LastIndexOf(x);
            bool Old_alContainsX = al.Contains(x);

            bool New_Ret = al.Contains(x);

            int New_alCount = al.Count;
            int New_x = x;
            int New_alIndexOfX = al.IndexOf(x);
            int New_alLastIndexOfX = al.LastIndexOf(x);
            bool New_alContainsX = al.Contains(x);

            PexObserve.ValueForViewing("$old_al_Count", Old_alCount);
            PexObserve.ValueForViewing("$new_al_Count", New_alCount);
            PexObserve.ValueForViewing("$old_al_x", Old_x);
            PexObserve.ValueForViewing("$new_al_x", New_x);
            PexObserve.ValueForViewing("$old_al_IndexOf_x", Old_alIndexOfX);
            PexObserve.ValueForViewing("$new_al_IndexOf_x", New_alIndexOfX);
            PexObserve.ValueForViewing("$old_al_LastIndexOf_x", Old_alLastIndexOfX);
            PexObserve.ValueForViewing("$new_al_LastIndexOf_x", New_alLastIndexOfX);
            PexObserve.ValueForViewing("$Old_ret", Old_Ret);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_al_contains_x", Old_alContainsX);
            PexObserve.ValueForViewing("$new_al_contains_x", New_alContainsX);

            PexAssert.IsTrue((( ! (New_alCount == New_alIndexOfX)) && ( ! (New_alCount == New_alLastIndexOfX)) && (New_alLastIndexOfX == Old_alLastIndexOfX) && (New_x == Old_x) && (New_alCount == Old_alCount) && (New_alIndexOfX == Old_alIndexOfX)));
        }

        [PexMethod]
        public void PUT_IndexOfContract([PexAssumeUnderTest]ArrayList al, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_alCount = al.Count;
            int Old_x = x;
            int Old_Ret = 2;
            int Old_alIndexOfX = al.IndexOf(x);
            int Old_alLastIndexOfX = al.LastIndexOf(x);
            bool Old_alContainsX = al.Contains(x);

            int New_Ret = al.IndexOf(x);

            int New_alCount = al.Count;
            int New_x = x;
            int New_alIndexOfX = al.IndexOf(x);
            int New_alLastIndexOfX = al.LastIndexOf(x);
            bool New_alContainsX = al.Contains(x);

            PexObserve.ValueForViewing("$old_al_Count", Old_alCount);
            PexObserve.ValueForViewing("$new_al_Count", New_alCount);
            PexObserve.ValueForViewing("$old_al_x", Old_x);
            PexObserve.ValueForViewing("$new_al_x", New_x);
            PexObserve.ValueForViewing("$old_al_IndexOf_x", Old_alIndexOfX);
            PexObserve.ValueForViewing("$new_al_IndexOf_x", New_alIndexOfX);
            PexObserve.ValueForViewing("$old_al_LastIndexOf_x", Old_alLastIndexOfX);
            PexObserve.ValueForViewing("$new_al_LastIndexOf_x", New_alLastIndexOfX);
            PexObserve.ValueForViewing("$Old_ret", Old_Ret);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_al_contains_x", Old_alContainsX);
            PexObserve.ValueForViewing("$new_al_contains_x", New_alContainsX);

            PexAssert.IsTrue((( ! (New_alCount == New_alLastIndexOfX)) && ( ! (New_alCount == New_Ret)) && (New_alLastIndexOfX == Old_alLastIndexOfX) && (New_x == Old_x) && (New_alCount == Old_alCount) && (New_alIndexOfX == Old_alIndexOfX) && (New_Ret == Old_alIndexOfX) && (Old_alContainsX) && (New_alContainsX)) || (( ! (New_alCount == New_Ret)) && (New_alLastIndexOfX == Old_alLastIndexOfX) && (New_x == Old_x) && (New_alCount == Old_alCount) && (New_alIndexOfX == Old_alIndexOfX) && (New_Ret == Old_alIndexOfX) && (New_alLastIndexOfX == New_Ret) && ( ! (Old_alIndexOfX == Old_Ret))));
        }

        [PexMethod]
        public void PUT_LastIndexOfContract([PexAssumeUnderTest]ArrayList al, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_alCount = al.Count;
            int Old_x = x;
            int Old_Ret = 2;
            int Old_alIndexOfX = al.IndexOf(x);
            int Old_alLastIndexOfX = al.LastIndexOf(x);
            bool Old_alContainsX = al.Contains(x);

            int New_Ret = al.LastIndexOf(x);

            int New_alCount = al.Count;
            int New_x = x;
            int New_alIndexOfX = al.IndexOf(x);
            int New_alLastIndexOfX = al.LastIndexOf(x);
            bool New_alContainsX = al.Contains(x);

            PexObserve.ValueForViewing("$old_al_Count", Old_alCount);
            PexObserve.ValueForViewing("$new_al_Count", New_alCount);
            PexObserve.ValueForViewing("$old_al_x", Old_x);
            PexObserve.ValueForViewing("$new_al_x", New_x);
            PexObserve.ValueForViewing("$old_al_IndexOf_x", Old_alIndexOfX);
            PexObserve.ValueForViewing("$new_al_IndexOf_x", New_alIndexOfX);
            PexObserve.ValueForViewing("$old_al_LastIndexOf_x", Old_alLastIndexOfX);
            PexObserve.ValueForViewing("$new_al_LastIndexOf_x", New_alLastIndexOfX);
            PexObserve.ValueForViewing("$Old_ret", Old_Ret);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_al_contains_x", Old_alContainsX);
            PexObserve.ValueForViewing("$new_al_contains_x", New_alContainsX);

            PexAssert.IsTrue((( ! (New_alCount == New_alIndexOfX)) && ( ! (New_alCount == New_Ret)) && (New_alLastIndexOfX == Old_alLastIndexOfX) && (New_x == Old_x) && (New_alCount == Old_alCount) && (New_alIndexOfX == Old_alIndexOfX) && (New_Ret == Old_alLastIndexOfX) && (Old_alContainsX) && (New_alContainsX)) || (( ! (New_alCount == New_Ret)) && (New_alLastIndexOfX == Old_alLastIndexOfX) && (New_x == Old_x) && (New_alCount == Old_alCount) && (New_alIndexOfX == Old_alIndexOfX) && (New_Ret == Old_alLastIndexOfX) && (New_alIndexOfX == New_Ret) && ( ! (Old_alIndexOfX == Old_Ret))));
        }

        [PexMethod]
        public void PUT_CountContract([PexAssumeUnderTest]ArrayList al)
        {
            AssumePrecondition.IsTrue(true);

            int Old_alCount = al.Count;
            int Old_Ret = 2;

            int New_Ret = al.Count;

            int New_alCount = al.Count;

            PexObserve.ValueForViewing("$old_al_Count", Old_alCount);
            PexObserve.ValueForViewing("$new_al_Count", New_alCount);
            PexObserve.ValueForViewing("$Old_ret", Old_Ret);
            PexObserve.ValueForViewing("$New_ret", New_Ret);

            PexAssert.IsTrue(((New_alCount == Old_alCount) && (New_Ret == Old_alCount)));
        }
    }
}