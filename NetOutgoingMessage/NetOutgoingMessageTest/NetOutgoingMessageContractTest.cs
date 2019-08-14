// <copyright file="NetOutgoingMessageContractTest.cs" company="Microsoft">Copyright © Microsoft 2010</copyright>
using System;
using System.Net;
using System.Reflection;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PexAPIWrapper;
using Microsoft.Pex.Framework.Settings;
using NetOutgoingMessage;

namespace NetOutgoingMessage.Test
{
    [PexClass(typeof(NetOutgoingMessage))]
    //[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    //[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class NetOutgoingMessageContractTest
    {

        public static bool IsNull(object obj)
        {
            return obj == null;
        }

        // [PexMethod]
        [PexMethod]
        public bool PUT_Encrypt(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            INetEncryption encryption
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_encryptionBytesLength = encryption != null ? ((NetXorEncryption)encryption).m_key.Length : -1;
            bool Old_encryptionIsNull = NetOutgoingMessageContractTest.IsNull(encryption);

            bool result = nom.Encrypt(encryption);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_encryptionBytesLength = encryption != null ? ((NetXorEncryption)encryption).m_key.Length : -1;
            bool New_encryptionIsNull = NetOutgoingMessageContractTest.IsNull(encryption);

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_encryption_bytes_length", Old_encryptionBytesLength);
            PexObserve.ValueForViewing("$new_encryption_bytes_length", New_encryptionBytesLength);
            PexObserve.ValueForViewing("$old_encryption_is_null", Old_encryptionIsNull);
            PexObserve.ValueForViewing("$new_encryption_is_null", New_encryptionIsNull);

            PexAssert.IsTrue(false);
            
            return result;
        }

        [PexMethod]
        public void PUT_EnsureBufferSize(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = numberOfBits;

            nom.EnsureBufferSize(numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_InternalEnsureBufferSize(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = numberOfBits;

            nom.InternalEnsureBufferSize(numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public int PUT_LengthBitsGet([PexAssumeUnderTest]NetOutgoingMessage nom)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            int result = nom.LengthBits;

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public void PUT_LengthBitsSet([PexAssumeUnderTest]NetOutgoingMessage nom, int value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_value = value;

            nom.LengthBits = value;

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_value = value;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_value", Old_value);
            PexObserve.ValueForViewing("$new_value", New_value);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public int PUT_LengthBytesGet([PexAssumeUnderTest]NetOutgoingMessage nom)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            int result = nom.LengthBytes;

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public void PUT_LengthBytesSet([PexAssumeUnderTest]NetOutgoingMessage nom, int value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_value = value;

            nom.LengthBytes = value;

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_value = value;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_value", Old_value);
            PexObserve.ValueForViewing("$new_value", New_value);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public byte[] PUT_PeekDataBuffer([PexAssumeUnderTest]NetOutgoingMessage nom)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            byte[] result = nom.PeekDataBuffer();

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public string PUT_ToString01([PexAssumeUnderTest]NetOutgoingMessage nom)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            string result = nom.ToString();

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public void PUT_Write([PexAssumeUnderTest]NetOutgoingMessage nom, bool value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            bool Old_value = value;

            nom.Write(value);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            bool New_value = value;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_value", Old_value);
            PexObserve.ValueForViewing("$new_value", New_value);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write01([PexAssumeUnderTest]NetOutgoingMessage nom, byte source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write02([PexAssumeUnderTest]NetOutgoingMessage nom, sbyte source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write03(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            byte source,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = numberOfBits;

            nom.Write(source, numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write04([PexAssumeUnderTest]NetOutgoingMessage nom, byte[] source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_sourceLength = source != null ? source.Length : -1;
            bool Old_sourceIsNull = NetOutgoingMessageContractTest.IsNull(source);

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_sourceLength = source != null ? source.Length : -1;
            bool New_sourceIsNull = NetOutgoingMessageContractTest.IsNull(source);

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_source_length", Old_sourceLength);
            PexObserve.ValueForViewing("$new_source_length", New_sourceLength);
            PexObserve.ValueForViewing("$old_source_is_null", Old_sourceIsNull);
            PexObserve.ValueForViewing("$new_source_is_null", New_sourceIsNull);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write05(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            byte[] source,
            int offsetInBytes,
            int numberOfBytes
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_offsetInBytes = offsetInBytes;
            int Old_numberOfBytes = numberOfBytes;
            int Old_sourceLength = source != null ? source.Length : -1;
            bool Old_sourceIsNull = NetOutgoingMessageContractTest.IsNull(source);

            nom.Write(source, offsetInBytes, numberOfBytes);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_offsetInBytes = offsetInBytes;
            int New_numberOfBytes = numberOfBytes;
            int New_sourceLength = source != null ? source.Length : -1;
            bool New_sourceIsNull = NetOutgoingMessageContractTest.IsNull(source);

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_offset_in_bytes", Old_offsetInBytes);
            PexObserve.ValueForViewing("$new_offset_in_bytes", New_offsetInBytes);
            PexObserve.ValueForViewing("$old_number_of_bytes", Old_numberOfBytes);
            PexObserve.ValueForViewing("$new_number_of_bytes", New_numberOfBytes);
            PexObserve.ValueForViewing("$old_source_length", Old_sourceLength);
            PexObserve.ValueForViewing("$new_source_length", New_sourceLength);
            PexObserve.ValueForViewing("$old_source_is_null", Old_sourceIsNull);
            PexObserve.ValueForViewing("$new_source_is_null", New_sourceIsNull);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write06([PexAssumeUnderTest]NetOutgoingMessage nom, ushort source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write07(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            ushort source,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = numberOfBits;

            nom.Write(source, numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write08([PexAssumeUnderTest]NetOutgoingMessage nom, short source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write09([PexAssumeUnderTest]NetOutgoingMessage nom, int source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_source = source;

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_source = source;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_source", Old_source);
            PexObserve.ValueForViewing("$new_source", New_source);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write10([PexAssumeUnderTest]NetOutgoingMessage nom, uint source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write11(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            uint source,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = numberOfBits;

            nom.Write(source, numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write12(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            int source,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = numberOfBits;
            int Old_source = source;

            nom.Write(source, numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = numberOfBits;
            int New_source = source;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);
            PexObserve.ValueForViewing("$old_source", Old_source);
            PexObserve.ValueForViewing("$new_source", New_source);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write13([PexAssumeUnderTest]NetOutgoingMessage nom, ulong source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write14(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            System.UInt64 source,
            System.Int32 numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = (int)numberOfBits;

            nom.Write(source, numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = (int)numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write15(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            long source
            )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write16(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            long source,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = (int)numberOfBits;

            nom.Write(source, numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = (int)numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write17([PexAssumeUnderTest]NetOutgoingMessage nom, float source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write18([PexAssumeUnderTest]NetOutgoingMessage nom, double source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write19([PexAssumeUnderTest]NetOutgoingMessage nom, string source)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_sourceLength = source != null ? source.Length : -1;
            bool Old_sourceIsNull = string.IsNullOrEmpty(source);

            nom.Write(source);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_sourceLength = source != null ? source.Length : -1;
            bool New_sourceIsNull = string.IsNullOrEmpty(source);

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_source_length", Old_sourceLength);
            PexObserve.ValueForViewing("$new_source_length", New_sourceLength);
            PexObserve.ValueForViewing("$old_source_is_null", Old_sourceIsNull);
            PexObserve.ValueForViewing("$new_source_is_null", New_sourceIsNull);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write20(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            IPEndPoint endPoint
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_endPointPort = endPoint != null ? endPoint.Port : PexChoose.Value<int>("old_end_point_port");
            bool Old_endPointIsNull = IsNull(endPoint);

            nom.Write(endPoint);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_endPointPort = endPoint != null ? endPoint.Port : PexChoose.Value<int>("new_end_point_port");
            bool New_endPointIsNull = IsNull(endPoint);

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_end_point_port", Old_endPointPort);
            PexObserve.ValueForViewing("$new_end_point_port", New_endPointPort);
            PexObserve.ValueForViewing("$old_end_point_is_null", Old_endPointIsNull);
            PexObserve.ValueForViewing("$new_end_point_is_null", New_endPointIsNull);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_Write21(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            NetOutgoingMessage message
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_messageLengthBits = !NetOutgoingMessageContractTest.IsNull(message) ? message.LengthBits : -1;
            int Old_messageLengthBytes = !NetOutgoingMessageContractTest.IsNull(message) ? message.LengthBytes : -1;
            int Old_messageBufferLength = !NetOutgoingMessageContractTest.IsNull(message) ? message.PeekDataBuffer().Length : -1;
            bool Old_messageIsNull = IsNull(message);

            nom.Write(message);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_messageLengthBits = !NetOutgoingMessageContractTest.IsNull(message) ? message.LengthBits : -1;
            int New_messageLengthBytes = !NetOutgoingMessageContractTest.IsNull(message) ? message.LengthBytes : -1;
            int New_messageBufferLength = !NetOutgoingMessageContractTest.IsNull(message) ? message.PeekDataBuffer().Length : -1;
            bool New_messageIsNull = IsNull(message);

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_message_length_bits", Old_messageLengthBits);
            PexObserve.ValueForViewing("$new_message_length_bits", New_messageLengthBits);
            PexObserve.ValueForViewing("$old_message_length_bytes", Old_messageLengthBytes);
            PexObserve.ValueForViewing("$new_message_length_bytes", New_messageLengthBytes);
            PexObserve.ValueForViewing("$old_message_buffer_length", Old_messageBufferLength);
            PexObserve.ValueForViewing("$new_message_buffer_length", New_messageBufferLength);
            PexObserve.ValueForViewing("$old_message_is_null", Old_messageIsNull);
            PexObserve.ValueForViewing("$new_message_is_null", New_messageIsNull);

            PexAssert.IsTrue(false);
        }

        //[PexMethod]
        [PexMethod(TestEmissionFilter = PexTestEmissionFilter.All )]        
        public void PUT_Write22(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            NetIncomingMessage message
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_messageLengthBits = !NetOutgoingMessageContractTest.IsNull(message) ? message.LengthBits : -1;
            int Old_messageLengthBytes = !NetOutgoingMessageContractTest.IsNull(message) ? message.LengthBytes : -1;
            int Old_messageBufferLength = !NetOutgoingMessageContractTest.IsNull(message) ? message.PeekDataBuffer().Length : -1;
            bool Old_messageIsNull = IsNull(message);

            nom.Write(message);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_messageLengthBits = !NetOutgoingMessageContractTest.IsNull(message) ? message.LengthBits : -1;
            int New_messageLengthBytes = !NetOutgoingMessageContractTest.IsNull(message) ? message.LengthBytes : -1;
            int New_messageBufferLength = !NetOutgoingMessageContractTest.IsNull(message) ? message.PeekDataBuffer().Length : -1;
            bool New_messageIsNull = IsNull(message);

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_message_length_bits", Old_messageLengthBits);
            PexObserve.ValueForViewing("$new_message_length_bits", New_messageLengthBits);
            PexObserve.ValueForViewing("$old_message_length_bytes", Old_messageLengthBytes);
            PexObserve.ValueForViewing("$new_message_length_bytes", New_messageLengthBytes);
            PexObserve.ValueForViewing("$old_message_buffer_length", Old_messageBufferLength);
            PexObserve.ValueForViewing("$new_message_buffer_length", New_messageBufferLength);
            PexObserve.ValueForViewing("$old_message_is_null", Old_messageIsNull);
            PexObserve.ValueForViewing("$new_message_is_null", New_messageIsNull);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_WriteAllFields([PexAssumeUnderTest]NetOutgoingMessage nom, object ob)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.WriteAllFields(ob);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_WriteAllFields01(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            object ob,
            BindingFlags flags
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.WriteAllFields(ob, flags);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_WriteAllProperties([PexAssumeUnderTest]NetOutgoingMessage nom, object ob)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.WriteAllProperties(ob);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_WriteAllProperties01(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            object ob,
            BindingFlags flags
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.WriteAllProperties(ob, flags);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_WritePadBits([PexAssumeUnderTest]NetOutgoingMessage nom)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            nom.WritePadBits();

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_WritePadBits01(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = numberOfBits;

            nom.WritePadBits(numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public int PUT_WriteRangedInteger(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            int min,
            int max,
            int value
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_min = min;
            int Old_max = max;
            int Old_value = value;

            int result = nom.WriteRangedInteger(min, max, value);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_min = min;
            int New_max = max;
            int New_value = value;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_min", Old_min);
            PexObserve.ValueForViewing("$new_min", New_min);
            PexObserve.ValueForViewing("$old_max", Old_max);
            PexObserve.ValueForViewing("$new_max", Old_max);
            PexObserve.ValueForViewing("$old_value", Old_value);
            PexObserve.ValueForViewing("$new_value", New_value);

            PexAssert.IsTrue(false);

            return result;
        }
           
        //[PexMethod(MaxRuns=200, TestEmissionFilter = PexTestEmissionFilter.All )]
        [PexMethod]
        public void PUT_WriteRangedSingle(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            float value,
            float min,
            float max,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = numberOfBits;

            nom.WriteRangedSingle(value, min, max, numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_WriteSignedSingle(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            float value,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = numberOfBits;

            nom.WriteSignedSingle(value, numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_WriteTime(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            double localTime,
            bool highPrecision
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            bool Old_highPrecision = highPrecision;

            nom.WriteTime(localTime, highPrecision);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            bool New_highPrecision = highPrecision;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_high_precision", Old_highPrecision);
            PexObserve.ValueForViewing("$new_high_precision", New_highPrecision);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_WriteUnitSingle(
            [PexAssumeUnderTest]NetOutgoingMessage nom,
            float value,
            int numberOfBits
        )
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_numberOfBits = numberOfBits;

            nom.WriteUnitSingle(value, numberOfBits);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_numberOfBits = numberOfBits;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_number_of_bits", Old_numberOfBits);
            PexObserve.ValueForViewing("$new_number_of_bits", New_numberOfBits);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public int PUT_WriteVariableInt32([PexAssumeUnderTest]NetOutgoingMessage nom, int value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int Old_value = value;

            int result = nom.WriteVariableInt32(value);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;
            int New_value = value;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$old_value", Old_value);
            PexObserve.ValueForViewing("$new_value", New_value);

            PexAssert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public int PUT_WriteVariableInt64([PexAssumeUnderTest]NetOutgoingMessage nom, long value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            int result = nom.WriteVariableInt64(value);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public int PUT_WriteVariableUInt32([PexAssumeUnderTest]NetOutgoingMessage nom, uint value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            int result = nom.WriteVariableUInt32(value);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);

            return result;
        }

        [PexMethod]
        public int PUT_WriteVariableUInt64([PexAssumeUnderTest]NetOutgoingMessage nom, ulong value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_nomLengthBits = nom.LengthBits;
            int Old_nomLengthBytes = nom.LengthBytes;
            int Old_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            int result = nom.WriteVariableUInt64(value);

            int New_nomLengthBits = nom.LengthBits;
            int New_nomLengthBytes = nom.LengthBytes;
            int New_nomPeekDataBufferLength = nom.PeekDataBuffer().Length;

            PexObserve.ValueForViewing("$old_nom_length_bits", Old_nomLengthBits);
            PexObserve.ValueForViewing("$new_nom_length_bits", New_nomLengthBits);
            PexObserve.ValueForViewing("$old_nom_length_bytes", Old_nomLengthBytes);
            PexObserve.ValueForViewing("$new_nom_length_bytes", New_nomLengthBytes);
            PexObserve.ValueForViewing("$old_nom_peek_data_buffer_length", Old_nomPeekDataBufferLength);
            PexObserve.ValueForViewing("$new_nom_peek_data_buffer_length", New_nomPeekDataBufferLength);

            PexAssert.IsTrue(false);

            return result;
        }
    }
}
