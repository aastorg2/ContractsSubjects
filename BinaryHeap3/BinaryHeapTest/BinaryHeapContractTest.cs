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
        public void PUT_AddContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int key, int value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_bhCount = bh.Count;
            //int Old_bhCapacity = bh.Capacity;
            int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("old_bhMinimumKey");
            int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("old_bhMinimumValue");
            //int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : key + 1; //PexChoose.Value<int>("old_bhMinimumKey");
            //int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : value + 1; //PexChoose.Value<int>("old_bhMinimumValue");
            
            int Old_bhIndexOfValue = bh.IndexOf(value);
            int Old_key = key;
            int Old_value = value;

            //code
            bh.Add(key, value);

            int New_bhCount = bh.Count;
            //int New_bhCapacity = bh.Capacity;
            int New_bhMinimumKey = bh.Minimum().Key;  // bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("new_bhMinimumKey");
            int New_bhMinimumValue =  bh.Minimum().Value; //bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("new_bhMinimumValue");
            int New_bhIndexOfValue = bh.IndexOf(value);

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_key", Old_key);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            //PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            //PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_indexof_value", Old_bhIndexOfValue);
            PexObserve.ValueForViewing("$new_bh_indexof_value", New_bhIndexOfValue);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);

            Assert.True(((New_bhMinimumKey <= Old_key && New_bhCount == 1 + Old_bhCount && (!(Old_bhIndexOfValue == Old_bhCount)) && Old_bhIndexOfValue <= Old_bhCount && New_bhIndexOfValue <= Old_bhCount && New_bhIndexOfValue >= 0 && Old_bhIndexOfValue >= -1)));
        }

        [PexMethod]
        public void PUT_MinimumContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh)
        {
            AssumePrecondition.IsTrue(bh.Count > 0);

            int Old_bhCount = bh.Count;
            //int Old_bhCapacity = bh.Capacity;
            int Old_bhMinimumKey = bh.Minimum().Key ;
            int Old_bhMinimumValue =  bh.Minimum().Value ;
            

            //code
            var m = bh.Minimum();
            int New_Ret_Key = m.Key;
            int New_Ret_Value = m.Value;

            int New_bhCount = bh.Count;
            //int New_bhCapacity = bh.Capacity;
            int New_bhMinimumKey =bh.Minimum().Key;
            int New_bhMinimumValue = bh.Minimum().Value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            //PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            //PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$new_ret_key", New_Ret_Key);
            PexObserve.ValueForViewing("$new_ret_value", New_Ret_Value);

            Assert.True(((Old_bhCount <= New_bhCount && New_bhCount <= Old_bhCount && New_Ret_Key == Old_bhMinimumKey && New_Ret_Value <= Old_bhMinimumValue && New_bhMinimumValue <= New_Ret_Value && New_bhMinimumKey == Old_bhMinimumKey && Old_bhMinimumValue <= New_bhMinimumValue && Old_bhCount >= 1)));
        }

        [PexMethod]
        public void PUT_RemoveMinimumContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh)
        {
            AssumePrecondition.IsTrue(bh.Count > 0);

            int Old_bhCount = bh.Count;
            int Old_bhMinimumKey =  bh.Minimum().Key;
            int Old_bhMinimumValue = bh.Minimum().Value;

            //code
            var rm = bh.RemoveMinimum();

            int New_Ret_Key = rm.Key;
            int New_Ret_Value = rm.Value;

            int New_bhCount = bh.Count;
            int New_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("new_bhMinimumKey");
            //int New_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : Old_bhMinimumKey -1 ;
            int New_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("new_bhMinimumValue");
            //int New_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : Old_bhMinimumValue -1;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$new_ret_key", New_Ret_Key);
            PexObserve.ValueForViewing("$new_ret_value", New_Ret_Value);


            Assert.True(((New_bhCount == -1 + Old_bhCount && Old_bhMinimumKey <= New_Ret_Key && New_Ret_Key <= Old_bhMinimumKey && New_Ret_Value <= Old_bhMinimumValue && Old_bhMinimumValue <= New_Ret_Value && New_bhCount >= 0)));

        }

        [PexMethod]
        public void PUT_RemoveAtContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int index)
        {
            AssumePrecondition.IsTrue(index < bh.Count && index >= 0);

            int Old_bhCount = bh.Count;
            int Old_bhMinimumKey = bh.Minimum().Key;
            int Old_bhMinimumValue = bh.Minimum().Value;
            int Old_index = index;
            //bool Old_removeAtRoot = index == 0;

            //code
            var ra = bh.RemoveAt(index);
            int New_Ret_Key = ra.Key;
            int New_Ret_Value = ra.Value;

            
            int New_bhCount = bh.Count;
            int New_bhMinimumKey =  bh.Count> 0 ? bh.Minimum().Key: PexChoose.Value<int>("new_min_key") ;
            //int New_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : Old_bhMinimumKey-1;
            
            int New_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("new_min_val");
            //int New_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : Old_bhMinimumValue - 1;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$old_bh_index", Old_index);

            PexObserve.ValueForViewing("$new_ret_key", New_Ret_Key);
            PexObserve.ValueForViewing("$new_ret_value", New_Ret_Value);

            Assert.True(((Old_index <= New_bhCount && New_bhCount == -1 + Old_bhCount && Old_bhMinimumKey <= New_Ret_Key && Old_index >= 0)));
        }

        [PexMethod]
        public void PUT_IndexOfContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int value)
        {
            // ahmad you can do this one: alternate semantics is that old ket and new key are the same; The same holds true for value
            AssumePrecondition.IsTrue(true);

            int Old_bhCount = bh.Count;
            int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("old_bhMinimumKey");
            int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("old_bhMinimumValue");
            int Old_value = value;

            //code
            int New_Ret = bh.IndexOf(value);

            int New_bhCount = bh.Count;
            int New_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("new_bhMinimumKey");
            int New_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("new_bhMinimumValue");

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            PexObserve.ValueForViewing("$new_ret", New_Ret);


            Assert.True((((!(New_Ret == Old_bhCount)) && New_Ret <= Old_bhCount && Old_bhCount <= New_bhCount && New_bhCount <= Old_bhCount && New_Ret >= -1)));

        }

        [PexMethod]
        public void PUT_UpdateContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int priority, int value)
        {
            //ahmad alternate semantics
            AssumePrecondition.IsTrue(true);

            int Old_bhCount = bh.Count;
            int Old_bhIndexOfValue = bh.IndexOf(value);
            int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("old_bhMinimumKey");
            //int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : priority -1;
            
            int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("old_bhMinimumValue");
            //int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : value -1;
            
            //int Old_bhMinimumKey = bh.Minimum().Key ;
            //int Old_bhMinimumValue = bh.Minimum().Value; 
            int Old_prioirty = priority;
            int Old_value = value;

            //code
            bh.Update(priority, value);

            int New_bhCount = bh.Count;
            int New_bhIndexOfValue = bh.IndexOf(value);
            //int New_bhMinimumKey = bh.Minimum().Key;
            int New_bhMinimumKey = bh.Minimum().Key;
            //int New_bhMinimumValue =  bh.Minimum().Value;
            int New_bhMinimumValue =  bh.Minimum().Value;
            //int New_prioirty = priority;
            //int New_value = value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_indexof_value", Old_bhIndexOfValue);
            PexObserve.ValueForViewing("$new_bh_indexof_value", New_bhIndexOfValue);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$old_bh_priority", Old_prioirty);
            //PexObserve.ValueForViewing("$new_bh_priority", New_prioirty);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            //PexObserve.ValueForViewing("$new_bh_value", New_value);

            Assert.True(((Old_bhCount <= New_bhCount && New_bhMinimumKey <= Old_prioirty && (!(New_bhIndexOfValue == New_bhCount)) && (!(Old_bhIndexOfValue == Old_bhCount)) && Old_bhIndexOfValue <= Old_bhCount && New_bhIndexOfValue <= Old_bhCount && New_bhIndexOfValue >= 0 && Old_bhIndexOfValue >= -1)));
        }

        [PexMethod]
        public void PUT_MinimumUpdateContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int priority, int value)
        {
            // ahmad alternate semantics same as bove
            AssumePrecondition.IsTrue(true);

            int Old_bhCount = bh.Count;
            //int Old_bhCapacity = bh.Capacity;
            int Old_bhIndexOfValue = bh.IndexOf(value);
            int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : PexChoose.Value<int>("old_bhMinimumKey");
            int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : PexChoose.Value<int>("old_bhMinimumValue");
            //int Old_bhMinimumKey = bh.Count > 0 ? bh.Minimum().Key : priority -1;
            //int Old_bhMinimumValue = bh.Count > 0 ? bh.Minimum().Value : value -1;
            int Old_prioirty = priority;
            int Old_value = value;

            //code
            bh.MinimumUpdate(priority, value);

            int New_bhCount = bh.Count;
            //int New_bhCapacity = bh.Capacity;
            int New_bhIndexOfValue = bh.IndexOf(value);
            int New_bhMinimumKey = bh.Minimum().Key; 
            int New_bhMinimumValue = bh.Minimum().Value;
            //int New_prioirty = priority;
            //int New_value = value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            //PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            //PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_indexof_value", Old_bhIndexOfValue);
            PexObserve.ValueForViewing("$new_bh_indexof_value", New_bhIndexOfValue);
            PexObserve.ValueForViewing("$old_bh_minimum_key", Old_bhMinimumKey);
            PexObserve.ValueForViewing("$new_bh_minimum_key", New_bhMinimumKey);
            PexObserve.ValueForViewing("$old_bh_minimum_value", Old_bhMinimumValue);
            PexObserve.ValueForViewing("$new_bh_minimum_value", New_bhMinimumValue);
            PexObserve.ValueForViewing("$old_bh_priority", Old_prioirty);
            //PexObserve.ValueForViewing("$new_bh_priority", New_prioirty);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            //PexObserve.ValueForViewing("$new_bh_value", New_value);

            Assert.True(((Old_bhCount <= New_bhCount && New_bhMinimumKey <= Old_prioirty && (!(Old_bhIndexOfValue == Old_bhCount)) && Old_bhIndexOfValue <= Old_bhCount && New_bhIndexOfValue <= Old_bhCount && (!(New_bhIndexOfValue == New_bhCount)) && Old_bhIndexOfValue >= -1 && New_bhIndexOfValue >= 0)));
        }
    }
}
