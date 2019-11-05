// <copyright file="NetBigIntegerContractTest.cs" company="Microsoft">Copyright © Microsoft 2010</copyright>
using System;
using NetBigInteger;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Settings;
using PexAPIWrapper;
using NUnit.Framework;

namespace NetBigInteger.Test
{
    [TestFixture, PexClass]
    public partial class NetBigIntegerContractTest
    {
        public static bool IsNull(NetBigInteger big)
        {
            return (big == null);
        }

        public static bool IsNull(object big)
        {
            return (big == null);
        }

        [PexMethod]
        public NetBigInteger PUT_AbsContract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;
            
            NetBigInteger result = nbi.Abs();

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_AddContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue((NetBigIntegerContractTest.IsNull(nbi2) && (((!(nbi1.IntValue <= -1)) && ((nbi1.IntValue <= 0))))) || ((!(NetBigIntegerContractTest.IsNull(nbi2)))));

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.Add(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);
            
            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_AndContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue((NetBigIntegerContractTest.IsNull(nbi2) && (((!(nbi1.IntValue <= -1)) && ((nbi1.IntValue <= 0))))) || ((!(NetBigIntegerContractTest.IsNull(nbi2)))));

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.And(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);
            
            return result;
        }

        [PexMethod]
        public int PUT_BitLengthGetContract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            int result = nbi.BitLength;

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public int PUT_CompareToContract([PexAssumeUnderTest]NetBigInteger nbi, object obj)
        {
            bool typeEqualTestClass = NetBigIntegerContractTest.IsNull(obj) ? false : (obj.GetType() == typeof(NetBigInteger));
            AssumePrecondition.IsTrue(typeEqualTestClass);

            bool Old_typeEqualTestClass = NetBigIntegerContractTest.IsNull(obj) ? false : (obj.GetType() == typeof(NetBigInteger));
            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            int result = nbi.CompareTo(obj);

            bool New_typeEqualTestClass = NetBigIntegerContractTest.IsNull(obj) ? false : (obj.GetType() == typeof(NetBigInteger));
            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);
            PexObserve.ValueForViewing("$old_type_equal_test_class", Old_typeEqualTestClass);
            PexObserve.ValueForViewing("$new_type_equal_test_class", New_typeEqualTestClass);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public int PUT_CompareTo01Contract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(((!(NetBigIntegerContractTest.IsNull(nbi2)))));

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            int result = nbi1.CompareTo(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);

            return result;
        }

        public static bool startsWithNonZeroSequence(string value)
        {
            bool nonZero = false;
            foreach (var s in value)
            {
                if (!s.Equals('0') && !s.Equals('\0') && !s.Equals('-') && !s.Equals('+'))
                {
                    nonZero = true;
                }
            }
            return nonZero;
        }

        [PexMethod]
        public NetBigInteger PUT_ConstructorContract(string str)
        {
            ulong temp;

            bool Old_isNullOrEmpty = string.IsNullOrEmpty(str);
            bool Old_isNullOrWhiteSpace = string.IsNullOrWhiteSpace(str);
            bool Old_tryParse = ulong.TryParse(str, out temp) ? ulong.TryParse(str, out temp) : false;
            bool Old_nullAtEnd = str != null ? str.EndsWith("\0") : true;
            bool Old_isNotBegZero = str != null ? startsWithNonZeroSequence(str) : false;
            bool Old_startWithSign = str != null ? str.StartsWith("+") | str.StartsWith("-") : false;

            AssumePrecondition.IsTrue((Old_tryParse && (((!(Old_startWithSign)) && ((Old_nullAtEnd && ((Old_isNotBegZero))) || ((!(Old_nullAtEnd))))))));

            NetBigInteger result = new NetBigInteger(str);

            bool New_isNullOrEmpty = string.IsNullOrEmpty(str);
            bool New_isNullOrWhiteSpace = string.IsNullOrWhiteSpace(str);
            bool New_tryParse = ulong.TryParse(str, out temp) ? ulong.TryParse(str, out temp) : false;
            bool New_nullAtEnd = str != null ? str.EndsWith("\0") : true;
            bool New_isNotBegZero = str != null ? startsWithNonZeroSequence(str) : false;
            bool New_startWithSign = str != null ? str.StartsWith("+") | str.StartsWith("-") : false;

            PexObserve.ValueForViewing("$old_is_null_or_empty", Old_isNullOrEmpty);
            PexObserve.ValueForViewing("$new_is_null_or_empty", New_isNullOrEmpty);
            PexObserve.ValueForViewing("$old_is_null_or_whitespace", Old_isNullOrWhiteSpace);
            PexObserve.ValueForViewing("$new_is_null_or_whitespace", New_isNullOrWhiteSpace);
            PexObserve.ValueForViewing("$old_try_parse", Old_tryParse);
            PexObserve.ValueForViewing("$new_try_parse", New_tryParse);
            PexObserve.ValueForViewing("$old_null_at_end", Old_nullAtEnd);
            PexObserve.ValueForViewing("$new_null_at_end", New_nullAtEnd);
            PexObserve.ValueForViewing("$old_is_not_beg_zero", Old_isNotBegZero);
            PexObserve.ValueForViewing("$new_is_not_beg_zero", New_isNotBegZero);
            PexObserve.ValueForViewing("$old_start_with_sign", Old_startWithSign);
            PexObserve.ValueForViewing("$new_start_with_sign", New_startWithSign);

            Assert.IsTrue(false);

            return result;
        }
        
        [PexMethod]
        public NetBigInteger PUT_Constructor01Contract(string str, int radix)
        {
            ulong temp;

            bool Old_isNullOrEmpty = string.IsNullOrEmpty(str);
            bool Old_isNullOrWhiteSpace = string.IsNullOrWhiteSpace(str);
            bool Old_tryParse = ulong.TryParse(str, out temp) ? ulong.TryParse(str, out temp) : false;
            bool Old_nullAtEnd = str != null ? str.EndsWith("\0") : true;
            bool Old_isNotBegZero = str != null ? startsWithNonZeroSequence(str) : false;
            bool Old_startWithSign = str != null ? str.StartsWith("+") | str.StartsWith("-") : false;
            int Old_radix = radix;

            AssumePrecondition.IsTrue((Old_tryParse && (((!(Old_startWithSign)) && ((radix <= 9 && (((!(Old_isNotBegZero)) && (((!(Old_nullAtEnd)) && ((Old_radix <= 2 && (((!(Old_radix <= 1))))))))))) || ((!(Old_radix <= 9)) && ((Old_isNotBegZero && ((Old_nullAtEnd) || ((!(Old_nullAtEnd)) && ((Old_radix <= 10) || ((!(Old_radix <= 10)) && (((!(Old_radix <= 15)) && ((Old_radix <= 16))))))))) || ((!(Old_isNotBegZero)) && (((!(Old_nullAtEnd)) && ((Old_radix <= 10) || ((!(Old_radix <= 10)) && (((!(Old_radix <= 15)) && ((Old_radix <= 16))))))))))))))));

            NetBigInteger target = new NetBigInteger(str, radix);

            bool New_isNullOrEmpty = string.IsNullOrEmpty(str);
            bool New_isNullOrWhiteSpace = string.IsNullOrWhiteSpace(str);
            bool New_tryParse = ulong.TryParse(str, out temp) ? ulong.TryParse(str, out temp) : false;
            bool New_nullAtEnd = str != null ? str.EndsWith("\0") : true;
            bool New_isNotBegZero = str != null ? startsWithNonZeroSequence(str) : false;
            bool New_startWithSign = str != null ? str.StartsWith("+") | str.StartsWith("-") : false;
            int New_radix = radix;

            PexObserve.ValueForViewing("$old_is_null_or_empty", Old_isNullOrEmpty);
            PexObserve.ValueForViewing("$new_is_null_or_empty", New_isNullOrEmpty);
            PexObserve.ValueForViewing("$old_is_null_or_whitespace", Old_isNullOrWhiteSpace);
            PexObserve.ValueForViewing("$new_is_null_or_whitespace", New_isNullOrWhiteSpace);
            PexObserve.ValueForViewing("$old_try_parse", Old_tryParse);
            PexObserve.ValueForViewing("$new_try_parse", New_tryParse);
            PexObserve.ValueForViewing("$old_null_at_end", Old_nullAtEnd);
            PexObserve.ValueForViewing("$new_null_at_end", New_nullAtEnd);
            PexObserve.ValueForViewing("$old_is_not_beg_zero", Old_isNotBegZero);
            PexObserve.ValueForViewing("$new_is_not_beg_zero", New_isNotBegZero);
            PexObserve.ValueForViewing("$old_start_with_sign", Old_startWithSign);
            PexObserve.ValueForViewing("$new_start_with_sign", New_startWithSign);
            PexObserve.ValueForViewing("$old_radix", Old_radix);
            PexObserve.ValueForViewing("$new_radix", New_radix);

            Assert.IsTrue(false);

            return target;
        }

        [PexMethod]
        public NetBigInteger PUT_Constructor02Contract(byte[] bytes)
        {
            int Old_bytesLength = !NetBigIntegerContractTest.IsNull(bytes) ? bytes.Length : -1;
            bool Old_bytesIsNull = NetBigIntegerContractTest.IsNull(bytes);

            AssumePrecondition.IsTrue(((!NetBigIntegerContractTest.IsNull(bytes)) && ((Old_bytesLength <= 1 && (((!(Old_bytesLength <= 0))))))));

            NetBigInteger result = new NetBigInteger(bytes);

            int New_bytesLength = !NetBigIntegerContractTest.IsNull(bytes) ? bytes.Length : -1;
            bool New_bytesIsNull = NetBigIntegerContractTest.IsNull(bytes);

            PexObserve.ValueForViewing("$old_bytes_length", Old_bytesLength);
            PexObserve.ValueForViewing("$new_bytes_length", New_bytesLength);
            PexObserve.ValueForViewing("$old_bytes_is_null", Old_bytesIsNull);
            PexObserve.ValueForViewing("$new_bytes_is_null", New_bytesIsNull);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_Constructor03Contract(
            byte[] bytes,
            int offset,
            int length
        )
        {
            bool Old_bytesIsNull = NetBigIntegerContractTest.IsNull(bytes);
            int Old_bytesLength = !NetBigIntegerContractTest.IsNull(bytes) ? bytes.Length : -1;
            int Old_offset = offset;
            int Old_length = length;

            AssumePrecondition.IsTrue(true);

            NetBigInteger result = new NetBigInteger(bytes, offset, length);

            bool New_bytesIsNull = NetBigIntegerContractTest.IsNull(bytes);
            int New_bytesLength = !NetBigIntegerContractTest.IsNull(bytes) ? bytes.Length : -1;
            int New_offset = offset;
            int New_length = length;

            PexObserve.ValueForViewing("$old_bytes_is_null", Old_bytesIsNull);
            PexObserve.ValueForViewing("$new_bytes_is_null", New_bytesIsNull);
            PexObserve.ValueForViewing("$old_bytes_length", Old_bytesLength);
            PexObserve.ValueForViewing("$new_bytes_length", New_bytesLength);
            PexObserve.ValueForViewing("$old_offset", Old_offset);
            PexObserve.ValueForViewing("$new_offset", New_offset);
            PexObserve.ValueForViewing("$old_length", Old_length);
            PexObserve.ValueForViewing("$new_length", New_length);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_Constructor04Contract(int sign, byte[] bytes)
        {
            AssumePrecondition.IsTrue(((!(sign <= -2)) && (((!NetBigIntegerContractTest.IsNull(bytes)) && ((sign <= 1))))));

            bool Old_bytesIsNull = NetBigIntegerContractTest.IsNull(bytes);
            int Old_bytesLength = !NetBigIntegerContractTest.IsNull(bytes) ? bytes.Length : -1;
            int Old_sign = sign;

            NetBigInteger result = new NetBigInteger(sign, bytes);

            bool New_bytesIsNull = NetBigIntegerContractTest.IsNull(bytes);
            int New_bytesLength = !NetBigIntegerContractTest.IsNull(bytes) ? bytes.Length : -1;
            int New_sign = sign;

            PexObserve.ValueForViewing("$old_bytes_is_null", Old_bytesIsNull);
            PexObserve.ValueForViewing("$new_bytes_is_null", New_bytesIsNull);
            PexObserve.ValueForViewing("$old_bytes_length", Old_bytesLength);
            PexObserve.ValueForViewing("$new_bytes_length", New_bytesLength);
            PexObserve.ValueForViewing("$old_sign", Old_sign);
            PexObserve.ValueForViewing("$new_sign", New_sign);

            Assert.IsTrue(false);
            
            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_Constructor05Contract(
            int sign,
            byte[] bytes,
            int offset,
            int length
        )
        {
            AssumePrecondition.IsTrue(true);

            bool Old_bytesIsNull = NetBigIntegerContractTest.IsNull(bytes);
            int Old_bytesLength = !NetBigIntegerContractTest.IsNull(bytes) ? bytes.Length : -1;
            int Old_offset = offset;
            int Old_length = length;
            int Old_sign = sign;

            NetBigInteger result = new NetBigInteger(sign, bytes, offset, length);

            bool New_bytesIsNull = NetBigIntegerContractTest.IsNull(bytes);
            int New_bytesLength = !NetBigIntegerContractTest.IsNull(bytes) ? bytes.Length : -1;
            int New_offset = offset;
            int New_length = length;
            int New_sign = sign;

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_DivideContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.Divide(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);
            
            return result;
        }

        [PexMethod]
        public NetBigInteger[] PUT_DivideAndRemainderContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger[] result = nbi1.DivideAndRemainder(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);
            
            return result;
        }

        [PexMethod]
        public bool PUT_Equals01Contract([PexAssumeUnderTest]NetBigInteger nbi, object obj)
        {
            AssumePrecondition.IsTrue(true);

            bool Old_typeEqualTestClass = NetBigIntegerContractTest.IsNull(obj) ? false : (obj.GetType() == typeof(NetBigInteger));
            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            bool result = nbi.Equals(obj);

            bool New_typeEqualTestClass = NetBigIntegerContractTest.IsNull(obj) ? false : (obj.GetType() == typeof(NetBigInteger));
            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);
            PexObserve.ValueForViewing("$old_type_equal_test_class", Old_typeEqualTestClass);
            PexObserve.ValueForViewing("$new_type_equal_test_class", New_typeEqualTestClass);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_GcdContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.Gcd(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public int PUT_GetHashCode01Contract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            int result = nbi.GetHashCode();

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public int PUT_GetLowestSetBitContract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            int result = nbi.GetLowestSetBit();

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public int PUT_IntValueGetContract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            int result = nbi.IntValue;

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_MaxContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.Max(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_MinContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.Min(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_ModContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.Mod(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_ModInverseContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.ModInverse(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_ModPowContract(
            [PexAssumeUnderTest]NetBigInteger nbi,
            NetBigInteger exponent,
            NetBigInteger value
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;
            int Old_exponentIntValue = !NetBigIntegerContractTest.IsNull(exponent) ? exponent.IntValue : PexChoose.Value<int>("old_exponent_int_value");
            int Old_exponentSignValue = !NetBigIntegerContractTest.IsNull(exponent) ? exponent.SignValue : PexChoose.Value<int>("old_exponent_sign_value");
            int Old_valueIntValue = !NetBigIntegerContractTest.IsNull(value) ? value.IntValue : PexChoose.Value<int>("old_value_int_value");
            int Old_valueSignValue = !NetBigIntegerContractTest.IsNull(value) ? value.SignValue : PexChoose.Value<int>("old_value_sign_value");
            bool Old_exponentIsNull = NetBigIntegerContractTest.IsNull(exponent);
            bool Old_valueIsNull = NetBigIntegerContractTest.IsNull(value);

            NetBigInteger result = nbi.ModPow(exponent, value);

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;
            int New_exponentIntValue = !NetBigIntegerContractTest.IsNull(exponent) ? exponent.IntValue : PexChoose.Value<int>("new_exponent_int_value");
            int New_exponentSignValue = !NetBigIntegerContractTest.IsNull(exponent) ? exponent.SignValue : PexChoose.Value<int>("new_exponent_sign_value");
            int New_valueIntValue = !NetBigIntegerContractTest.IsNull(value) ? value.IntValue : PexChoose.Value<int>("new_value_int_value");
            int New_valueSignValue = !NetBigIntegerContractTest.IsNull(value) ? value.SignValue : PexChoose.Value<int>("new_value_sign_value");
            bool New_exponentIsNull = NetBigIntegerContractTest.IsNull(exponent);
            bool New_valueIsNull = NetBigIntegerContractTest.IsNull(value);

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);
            PexObserve.ValueForViewing("$old_exponent_int_value", Old_exponentIntValue);
            PexObserve.ValueForViewing("$new_exponent_int_value", New_exponentIntValue);
            PexObserve.ValueForViewing("$old_exponent_sign_value", Old_exponentSignValue);
            PexObserve.ValueForViewing("$new_exponent_sign_value", New_exponentSignValue);
            PexObserve.ValueForViewing("$old_value_int_value", Old_valueIntValue);
            PexObserve.ValueForViewing("$new_value_int_value", New_valueIntValue);
            PexObserve.ValueForViewing("$old_value_sign_value", Old_valueSignValue);
            PexObserve.ValueForViewing("$new_value_sign_value", New_valueSignValue);
            PexObserve.ValueForViewing("$old_exponent_is_null", Old_exponentIsNull);
            PexObserve.ValueForViewing("$new_exponent_is_null", New_exponentIsNull);
            PexObserve.ValueForViewing("$old_value_is_null", Old_valueIsNull);
            PexObserve.ValueForViewing("$new_value_is_null", New_valueIsNull);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_ModulusContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.Modulus(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_MultiplyContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.Multiply(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_NegateContract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            NetBigInteger result = nbi.Negate();

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_NotContract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            NetBigInteger result = nbi.Not();

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_RemainderContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.Remainder(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);

            return result;
        }   

        [PexMethod]
        public NetBigInteger PUT_ShiftLeftContract([PexAssumeUnderTest]NetBigInteger nbi, int n)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;
            int Old_n = n;

            NetBigInteger result = nbi.ShiftLeft(n);

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;
            int New_n = n;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);
            PexObserve.ValueForViewing("$old_n", Old_n);
            PexObserve.ValueForViewing("$new_n", New_n);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_ShiftRightContract([PexAssumeUnderTest]NetBigInteger nbi, int n)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;
            int Old_n = n;

            NetBigInteger result = nbi.ShiftRight(n);

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;
            int New_n = n;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);
            PexObserve.ValueForViewing("$old_n", Old_n);
            PexObserve.ValueForViewing("$new_n", New_n);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public int PUT_SignValueGetContract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            int result = nbi.SignValue;

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_SubtractContract([PexAssumeUnderTest]NetBigInteger nbi1, NetBigInteger nbi2)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbi1IntValue = nbi1.IntValue;
            int Old_nbi1SignValue = nbi1.SignValue;
            int Old_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("old_nbi2_int_value");
            int Old_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("old_nbi2_sign_value");
            bool Old_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            NetBigInteger result = nbi1.Subtract(nbi2);

            int New_nbi1IntValue = nbi1.IntValue;
            int New_nbi1SignValue = nbi1.SignValue;
            int New_nbi2IntValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.IntValue : PexChoose.Value<int>("new_nbi2_int_value");
            int New_nbi2SignValue = !NetBigIntegerContractTest.IsNull(nbi2) ? nbi2.SignValue : PexChoose.Value<int>("new_nbi2_sign_value");
            bool New_nbi2IsNull = NetBigIntegerContractTest.IsNull(nbi2);

            PexObserve.ValueForViewing("$old_nbi1_int_value", Old_nbi1IntValue);
            PexObserve.ValueForViewing("$new_nbi1_int_value", New_nbi1IntValue);
            PexObserve.ValueForViewing("$old_nbi1_sign_value", Old_nbi1SignValue);
            PexObserve.ValueForViewing("$new_nbi1_sign_value", New_nbi1SignValue);
            PexObserve.ValueForViewing("$old_nbi2_int_value", Old_nbi2IntValue);
            PexObserve.ValueForViewing("$new_nbi2_int_value", New_nbi2IntValue);
            PexObserve.ValueForViewing("$old_nbi2_sign_value", Old_nbi2SignValue);
            PexObserve.ValueForViewing("$new_nbi2_sign_value", New_nbi2SignValue);
            PexObserve.ValueForViewing("$old_nbi2_is_null", Old_nbi2IsNull);
            PexObserve.ValueForViewing("$new_nbi2_is_null", New_nbi2IsNull);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public bool PUT_TestBitContract([PexAssumeUnderTest]NetBigInteger nbi, int n)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;
            int Old_n = n;

            bool result = nbi.TestBit(n);

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;
            int New_n = n;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);
            PexObserve.ValueForViewing("$old_n", Old_n);
            PexObserve.ValueForViewing("$new_n", New_n);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public byte[] PUT_ToByteArrayContract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            byte[] result = nbi.ToByteArray();

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public byte[] PUT_ToByteArrayUnsignedContract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            byte[] result = nbi.ToByteArrayUnsigned();

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public string PUT_ToString01Contract([PexAssumeUnderTest]NetBigInteger nbi)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;

            string result = nbi.ToString();

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public string PUT_ToString02Contract([PexAssumeUnderTest]NetBigInteger nbi, int radix)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nbiIntValue = nbi.IntValue;
            int Old_nbiSignValue = nbi.SignValue;
            int Old_radix = radix;

            string result = nbi.ToString();

            int New_nbiIntValue = nbi.IntValue;
            int New_nbiSignValue = nbi.SignValue;
            int New_radix = radix;

            PexObserve.ValueForViewing("$old_nbi_int_value", Old_nbiIntValue);
            PexObserve.ValueForViewing("$new_nbi_int_value", New_nbiIntValue);
            PexObserve.ValueForViewing("$old_nbi_sign_value", Old_nbiSignValue);
            PexObserve.ValueForViewing("$new_nbi_sign_value", New_nbiSignValue);
            PexObserve.ValueForViewing("$old_radix", Old_radix);
            PexObserve.ValueForViewing("$new_radix", New_radix);

            Assert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public NetBigInteger PUT_ValueOfContract(long value)
        {
            AssumePrecondition.IsTrue(true);

            long Old_value = value;

            NetBigInteger result = NetBigInteger.ValueOf(value);

            long New_value = value;

            PexObserve.ValueForViewing("$old_value", Old_value);
            PexObserve.ValueForViewing("$new_value", New_value);

            Assert.IsTrue(false);

            return result;
        }
    }
}
