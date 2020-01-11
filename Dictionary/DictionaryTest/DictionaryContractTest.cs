using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Dictionary;
using PexAPIWrapper;


namespace Dictionary.Test
{
    [PexClass]
    public partial class DictionaryContractTest
    {
        [PexMethod]
        public void PUT_AddContract([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d, int x, int y)
        {
            AssumePrecondition.IsTrue(!(d.ContainsKey(x)));

            int Old_dCount = d.Count;
            int Old_x = x;
            int Old_y = y;
            bool Old_dContainsKeyX = d.ContainsKey(x);
            bool Old_dContainsKeyY = d.ContainsKey(y);
            bool Old_dContainsValueX = d.ContainsValue(x);
            bool Old_dContainsValueY = d.ContainsValue(y);

            d.Add(x, y);

            int New_dCount = d.Count;
            int New_x = x;
            int New_y = y;
            bool New_dContainsKeyX = d.ContainsKey(x);
            bool New_dContainsKeyY = d.ContainsKey(y);
            bool New_dContainsValueX = d.ContainsValue(x);
            bool New_dContainsValueY = d.ContainsValue(y);
            
            PexObserve.ValueForViewing("$old_d_Count", Old_dCount);
            PexObserve.ValueForViewing("$new_d_Count", New_dCount);
            PexObserve.ValueForViewing("$old_d_x", Old_x);
            PexObserve.ValueForViewing("$new_d_x", New_x);
            PexObserve.ValueForViewing("$old_d_y", Old_y);
            PexObserve.ValueForViewing("$new_d_y", New_y);

            //PexObserve.ValueForViewing("$Old_dContainsValueX", Old_dContainsValueX);
            //PexObserve.ValueForViewing("$New_dContainsValueX", New_dContainsValueX);
            //PexObserve.ValueForViewing("$Old_dContainsKeyY", Old_dContainsKeyY);
            //PexObserve.ValueForViewing("$New_dContainsKeyY ", New_dContainsKeyY);

            PexObserve.ValueForViewing("$old_d_contains_key_x", Old_dContainsKeyX);
            PexObserve.ValueForViewing("$new_d_contains_key_x", New_dContainsKeyX);
            PexObserve.ValueForViewing("$old_d_contains_value_y", Old_dContainsValueY);
            PexObserve.ValueForViewing("$new_d_contains_value_y", New_dContainsValueY);

            Assert.True((New_dContainsKeyX && New_dContainsValueY && New_dCount == Old_dCount + 1 && New_x == Old_x && New_y == Old_y && (!(Old_dContainsKeyX)) && New_dCount != Old_dCount));
        }

        [PexMethod]
        public void PUT_RemoveContract([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_dCount = d.Count;
            int Old_x = x;
            bool Old_dContainsKeyX = d.ContainsKey(x);

            bool New_Ret = d.Remove(x);

            int New_dCount = d.Count;
            int New_x = x;
            bool New_dContainsKeyX = d.ContainsKey(x);

            PexObserve.ValueForViewing("$old_d_Count", Old_dCount);
            PexObserve.ValueForViewing("$new_d_Count", New_dCount);
            PexObserve.ValueForViewing("$old_d_x", Old_x);
            PexObserve.ValueForViewing("$new_d_x", New_x);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_d_contains_key_x", Old_dContainsKeyX);
            PexObserve.ValueForViewing("$new_d_contains_key_x", New_dContainsKeyX);

            Assert.True(((New_x == Old_x && (!(New_dContainsKeyX))) && ((((New_Ret && New_dCount == Old_dCount - 1 && New_dCount != Old_dCount) && (((New_dCount == Old_x &&  Old_x != Old_dCount &&  New_x != Old_dCount &&  Old_x == New_dCount) && New_x == New_dCount) || ((Old_x != New_dCount &&  New_x != New_dCount) && (!(New_x == New_dCount))))) && Old_dContainsKeyX) || (((New_dCount == Old_dCount && (!(New_Ret))) && (((New_x == Old_dCount &&  Old_x == Old_dCount &&  Old_x == New_dCount) && New_x == New_dCount) || ((Old_x != Old_dCount &&  New_x != Old_dCount &&  Old_x != New_dCount &&  New_x != New_dCount) && (!(New_x == New_dCount))))) && (!(Old_dContainsKeyX))))));
        }

        [PexMethod]
        public void PUT_GetContract([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d, int x)
        {
            AssumePrecondition.IsTrue(d.ContainsKey(x));

            int Old_dCount = d.Count;
            int Old_x = x;
            bool Old_dContainsKeyX = d.ContainsKey(x);

            int New_Ret = d[x];

            int New_dCount = d.Count;
            int New_x = x;
            bool New_dContainsKeyX = d.ContainsKey(x);
            bool New_ContainsKeyNewRet = d.ContainsKey(New_Ret);
            bool New_ContainsValueNewRet = d.ContainsValue(New_Ret);

            PexObserve.ValueForViewing("$old_d_Count", Old_dCount);
            PexObserve.ValueForViewing("$new_d_Count", New_dCount);
            PexObserve.ValueForViewing("$old_d_x", Old_x);
            PexObserve.ValueForViewing("$new_d_x", New_x);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_d_contains_key_x", Old_dContainsKeyX);
            PexObserve.ValueForViewing("$new_d_contains_key_x", New_dContainsKeyX);
            PexObserve.ValueForViewing("$old_d_contains_key_x", New_ContainsKeyNewRet);
            PexObserve.ValueForViewing("$new_d_contains_key_x", New_ContainsValueNewRet);

            Assert.True(((Old_dContainsKeyX && New_dContainsKeyX && New_ContainsValueNewRet && New_dCount == Old_dCount && New_x == Old_x) && ((((New_ContainsKeyNewRet && New_Ret == Old_x) && (((New_x == Old_dCount &&  New_Ret == Old_dCount &&  Old_x == Old_dCount &&  Old_x == New_dCount &&  New_x == New_dCount) && New_Ret == New_dCount) || ((Old_x != Old_dCount &&  New_x != Old_dCount &&  New_Ret != Old_dCount &&  Old_x != New_dCount &&  New_x != New_dCount &&  New_Ret != New_dCount) && (!(New_Ret == New_dCount))))) && New_Ret == New_x) || (((New_Ret != Old_x && New_Ret != New_x) && (((New_Ret == Old_dCount &&  Old_x != Old_dCount &&  New_x != Old_dCount &&  Old_x != New_dCount &&  New_x != New_dCount) && New_Ret == New_dCount) || ((New_Ret != Old_dCount &&  New_Ret != New_dCount) && (!(New_Ret == New_dCount))))) && (!(New_Ret == New_x))))));
        }

        [PexMethod]
        public void PUT_SetContract([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d, int x, int y)
        {
            AssumePrecondition.IsTrue(true);

            int Old_dCount = d.Count;
            int Old_x = x;
            int Old_y = y;
            bool Old_dContainsKeyX = d.ContainsKey(x);
            bool Old_dContainsValueY = d.ContainsValue(y);

            d[x] = y;

            int New_dCount = d.Count;
            int New_x = x;
            int New_y = y;
            bool New_dContainsKeyX = d.ContainsKey(x);
            bool New_dContainsValueY = d.ContainsValue(y);

            PexObserve.ValueForViewing("$old_d_Count", Old_dCount);
            PexObserve.ValueForViewing("$new_d_Count", New_dCount);
            PexObserve.ValueForViewing("$old_d_x", Old_x);
            PexObserve.ValueForViewing("$new_d_x", New_x);
            PexObserve.ValueForViewing("$old_d_y", Old_y);
            PexObserve.ValueForViewing("$new_d_y", New_y);
            PexObserve.ValueForViewing("$old_d_contains_key_x", Old_dContainsKeyX);
            PexObserve.ValueForViewing("$new_d_contains_key_x", New_dContainsKeyX);
            PexObserve.ValueForViewing("$old_d_contains_value_y", Old_dContainsValueY);
            PexObserve.ValueForViewing("$new_d_contains_value_y", New_dContainsValueY);

            Assert.True(((New_dContainsKeyX && New_dContainsValueY && New_x == Old_x && New_y == Old_y) && ((((New_dCount == Old_dCount) && (((New_y == Old_x &&  Old_y == Old_x &&  Old_y == New_x) && New_y == New_x) || ((Old_y != Old_x &&  New_y != Old_x &&  Old_y != New_x &&  New_y != New_x) && (!(New_y == New_x))))) && Old_dContainsKeyX) || (((New_dCount == Old_dCount + 1 && New_dCount != Old_dCount) && (((New_y == Old_x &&  Old_y == Old_x &&  Old_y == New_x) && New_y == New_x) || ((Old_y != Old_x &&  New_y != Old_x &&  Old_y != New_x &&  New_y != New_x) && (!(New_y == New_x))))) && (!(Old_dContainsKeyX))))));
        }

        [PexMethod]
        public void PUT_ContainsKeyContract([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d, int x)
        {
            AssumePrecondition.IsTrue(true);

            int Old_dCount = d.Count;
            int Old_x = x;
            bool Old_dContainsKeyX = d.ContainsKey(x);

            bool New_Ret = d.ContainsKey(x);

            int New_dCount = d.Count;
            int New_x = x;
            bool New_dContainsKeyX = d.ContainsKey(x);

            PexObserve.ValueForViewing("$old_d_Count", Old_dCount);
            PexObserve.ValueForViewing("$new_d_Count", New_dCount);
            PexObserve.ValueForViewing("$old_d_x", Old_x);
            PexObserve.ValueForViewing("$new_d_x", New_x);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_d_contains_key_x", Old_dContainsKeyX);
            PexObserve.ValueForViewing("$new_d_contains_key_x", New_dContainsKeyX);

            Assert.True(((New_dCount == Old_dCount && New_x == Old_x) && ((((New_Ret && Old_dContainsKeyX) && (((New_x == Old_dCount &&  Old_x == Old_dCount &&  Old_x == New_dCount) && New_x == New_dCount) || ((Old_x != Old_dCount &&  New_x != Old_dCount &&  Old_x != New_dCount &&  New_x != New_dCount) && (!(New_x == New_dCount))))) && New_dContainsKeyX) || ((((!(New_Ret)) && (!(Old_dContainsKeyX))) && (((New_x == Old_dCount &&  Old_x == Old_dCount &&  Old_x == New_dCount) && New_x == New_dCount) || ((Old_x != Old_dCount &&  New_x != Old_dCount &&  Old_x != New_dCount &&  New_x != New_dCount) && (!(New_x == New_dCount))))) && (!(New_dContainsKeyX))))));
        }

        [PexMethod]
        public void PUT_ContainsValueContract([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d, int y)
        {
            AssumePrecondition.IsTrue(true);

            int Old_dCount = d.Count;
            int Old_y = y;
            bool Old_dContainsValueY = d.ContainsValue(y);

            bool New_Ret = d.ContainsValue(y);

            int New_dCount = d.Count;
            int New_y = y;
            bool New_dContainsValueY = d.ContainsValue(y);

            PexObserve.ValueForViewing("$old_d_Count", Old_dCount);
            PexObserve.ValueForViewing("$new_d_Count", New_dCount);
            PexObserve.ValueForViewing("$old_d_y", Old_y);
            PexObserve.ValueForViewing("$new_d_y", New_y);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$old_d_contains_value_y", Old_dContainsValueY);
            PexObserve.ValueForViewing("$new_d_contains_value_y", New_dContainsValueY);
            
            Assert.True(((New_dCount == Old_dCount && New_y == Old_y) && ((((New_Ret && Old_dContainsValueY) && (((New_y == Old_dCount &&  Old_y == Old_dCount &&  Old_y == New_dCount) && New_y == New_dCount) || ((Old_y != Old_dCount &&  New_y != Old_dCount &&  Old_y != New_dCount &&  New_y != New_dCount) && (!(New_y == New_dCount))))) && New_dContainsValueY) || ((((!(New_Ret)) && (!(Old_dContainsValueY))) && (((New_y == Old_dCount &&  Old_y == Old_dCount &&  Old_y == New_dCount) && New_y == New_dCount) || ((Old_y != Old_dCount &&  New_y != Old_dCount &&  Old_y != New_dCount &&  New_y != New_dCount) && (!(New_y == New_dCount))))) && (!(New_dContainsValueY))))));
        }
        
        [PexMethod]
        public void PUT_CountContract([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d)
        {
            AssumePrecondition.IsTrue(true);

            int Old_dCount = d.Count;

            int New_Ret = d.Count;
            
            int New_dCount = d.Count;
            bool New_ContainsKeyNewRet = d.ContainsKey(New_Ret);
            bool New_ContainsValueNewRet = d.ContainsValue(New_Ret);

            PexObserve.ValueForViewing("$old_d_Count", Old_dCount);
            PexObserve.ValueForViewing("$new_d_Count", New_dCount);
            PexObserve.ValueForViewing("$New_ret", New_Ret);
            PexObserve.ValueForViewing("$newRetKey", New_ContainsKeyNewRet);
            PexObserve.ValueForViewing("$newRetValue", New_ContainsValueNewRet);

            Assert.True((New_dCount == Old_dCount && New_Ret == Old_dCount && New_Ret == New_dCount));
        }
        
        [PexMethod]
        public void testFactorySize([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d)
        {
            bool hit = true;
            if (d.Count > 5)
                Assert.True(false);

            
        }

        [PexMethod]
        public bool testFactoryContains([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d, int y)
        {
            bool hit = true;
            bool ret = d.ContainsValue(y);
            if (d.Count == y)
                Assert.True(false);
            return ret;

        }
        
        [PexMethod] // !New_x == New_dCount !New_y == New_dCoun
        public void testKeySameAsCountAfterAdding([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d, int x, int y)
        {
            PexAssume.IsTrue(!d.ContainsKey(x));
            bool hit = true;
            d.Add(x, y);
            if (x == d.Count)
                hit = false;
            PexAssert.IsTrue(hit);
        }

        [PexMethod] // !New_x == New_dCount !New_y == New_dCoun
        public void testValueSameAsCountAfterAdding([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d, int x, int y)
        {
            PexAssume.IsTrue(!d.ContainsKey(x));
            bool hit = true;
            d.Add(x, y);
            if (y == d.Count)
                hit = false;
            PexAssert.IsTrue(hit);
        }

        [PexMethod] // !New_x == New_dCount !New_y == New_dCoun
        public void testKeySameAsCountAfterAddingWithValueAlreadyInDict([PexAssumeUnderTest]Dictionary.Dictionary<int, int> d, int x, int y)
        {
            PexAssume.IsTrue(!d.ContainsKey(x) && d.ContainsValue(y));
            bool hit = true;
            d.Add(x, y);
            if (x == d.Count)
                hit = false;
            PexAssert.IsTrue(hit);
        }
    }
}