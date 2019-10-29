using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using BinaryHeap;
using Common.Utility4QuickGraph3;
using PexAPIWrapper;

namespace BinaryHeap.Test
{
    [TestFixture, PexClass]
    public partial class BinaryHeapContractTest
    {
        [PexMethod]
        public void PUT_AddContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int priority, int value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_bhCount = bh.Count;
            //int Old_bhCapacity = bh.Capacity;
            int Old_bhIndexOfValue = bh.IndexOf(value);
            int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("old_bhMinimumKey");
            int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("old_bhMinimumValue");
            int Old_prioirty = priority;
            int Old_value = value;

            //code
            bh.Add(priority, value);

            int New_bhCount = bh.Count;
            //int New_bhCapacity = bh.Capacity;
            int Newd_bhIndexOfValue = bh.IndexOf(value);
            int New_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("new_bhMinimumKey");
            int New_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("new_bhMinimumValue");
            int New_prioirty = priority;
            int New_value = value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            //PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            //PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_indexof_value", Old_bhIndexOfValue);
            PexObserve.ValueForViewing("$new_bh_indexof_value", Newd_bhIndexOfValue);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$old_bh_priority", Old_prioirty);
            PexObserve.ValueForViewing("$new_bh_priority", New_prioirty);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            PexObserve.ValueForViewing("$new_bh_value", New_value);

            

            Assert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_MinimumContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh)
        {
            AssumePrecondition.IsTrue(bh.Count > 0);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_bhMinimumKey = bh.Minimum().Key ;
            int Old_bhMinimumValue =  bh.Minimum().Value ;
            

            //code
            var m = bh.Minimum();
            int New_Ret_Key = m.Key;
            int New_Ret_Value = m.Value;

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;
            int New_bhMinimumKey =bh.Minimum().Key;
            int New_bhMinimumValue = bh.Minimum().Value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$new_ret_key", New_Ret_Key);
            PexObserve.ValueForViewing("$new_ret_value", New_Ret_Value);

            Assert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_RemoveMinimumContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh)
        {
            AssumePrecondition.IsTrue(bh.Count > 0);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_bhMinimumKey =  bh.Minimum().Key;
            int Old_bhMinimumValue = bh.Minimum().Value;

            //code
            var rm = bh.RemoveMinimum();
            int New_Ret_Key = rm.Key;
            int New_Ret_Value = rm.Value;

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;
            int New_bhMinimumKey = bh.Minimum().Key ;
            int New_bhMinimumValue = bh.Minimum().Value ;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$new_ret_key", New_Ret_Key);
            PexObserve.ValueForViewing("$new_ret_value", New_Ret_Value);

            Assert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_RemoveAtContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int index)
        {
            AssumePrecondition.IsTrue(index < bh.Count && index >= 0);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_bhMinimumKey = bh.Minimum().Key;
            int Old_bhMinimumValue = bh.Minimum().Value;
            int Old_index = index;
           

            //code
            var ra = bh.RemoveAt(index);
            int New_Ret_Key = ra.Key;
            int New_Ret_Value = ra.Value;

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;
            int New_bhMinimumKey =  bh.Count> 0 ? bh.Minimum().Key: PexChoose.Value<int>("new_min_key") ;
            int New_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("new_min_val");
            int New_index = index;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$old_bh_index", Old_index);
            PexObserve.ValueForViewing("$new_bh_index", New_index);
            PexObserve.ValueForViewing("$new_ret_key", New_Ret_Key);
            PexObserve.ValueForViewing("$new_ret_value", New_Ret_Value);

            Assert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_IndexOfContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("old_bhMinimumKey");
            int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("old_bhMinimumValue");
            int Old_value = value;

            //code
            int New_Ret = bh.IndexOf(value);

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;
            int New_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("new_bhMinimumKey");
            int New_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("new_bhMinimumValue");
            int New_value = value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            PexObserve.ValueForViewing("$new_bh_value", New_value);
            PexObserve.ValueForViewing("$new_ret", New_Ret);

            Assert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_UpdateContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int priority, int value)
        {
            AssumePrecondition.IsTrue(bh.IndexOf(value) >= 0);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_bhIndexOfValue = bh.IndexOf(value);
            //int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("old_bhMinimumKey");
            //int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("old_bhMinimumValue");
            int Old_bhMinimumKey = bh.Minimum().Key ;
            int Old_bhMinimumValue = bh.Minimum().Value; 
            int Old_prioirty = priority;
            int Old_value = value;

            //code
            bh.Update(priority, value);

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;
            int Newd_bhIndexOfValue = bh.IndexOf(value);
            int New_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("new_bhMinimumKey");
            int New_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("new_bhMinimumValue");
            int New_prioirty = priority;
            int New_value = value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_indexof_value", Old_bhIndexOfValue);
            PexObserve.ValueForViewing("$new_bh_indexof_value", Newd_bhIndexOfValue);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$old_bh_priority", Old_prioirty);
            PexObserve.ValueForViewing("$new_bh_priority", New_prioirty);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            PexObserve.ValueForViewing("$new_bh_value", New_value);


            Assert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_MinimumUpdateContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int priority, int value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_bhIndexOfValue = bh.IndexOf(value);
            int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("old_bhMinimumKey");
            int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("old_bhMinimumValue");
            //int Old_bhMinimumKey = bh.Minimum().Key;
            //int Old_bhMinimumValue = bh.Minimum().Value;
            int Old_prioirty = priority;
            int Old_value = value;

            //code
            bh.MinimumUpdate(priority, value);

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;
            int Newd_bhIndexOfValue = bh.IndexOf(value);
            int New_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("new_bhMinimumKey");
            int New_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("new_bhMinimumValue");
            int New_prioirty = priority;
            int New_value = value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_indexof_value", Old_bhIndexOfValue);
            PexObserve.ValueForViewing("$new_bh_indexof_value", Newd_bhIndexOfValue);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$old_bh_priority", Old_prioirty);
            PexObserve.ValueForViewing("$new_bh_priority", New_prioirty);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            PexObserve.ValueForViewing("$new_bh_value", New_value);

            Assert.IsTrue(false);
        }
    }
}
