using System;
using Microsoft.Pex.Framework;
using NetBigInteger;

namespace NetBigInteger.Test.Factories
{
    /// <summary>A factory for Lidgren.Network.NetBigInteger instances</summary>
    public static partial class NetBigIntegerFactory
    {
        /// <summary>A factory for Lidgren.Network.NetBigInteger instances</summary>
       /* [PexFactoryMethod(typeof(NetBigInteger))]
        public static NetBigInteger Create(byte[] bytes_bs, int offset_i, int length_i1)
        {
            NetBigInteger netBigInteger = new NetBigInteger(bytes_bs, offset_i, length_i1);
            return netBigInteger;

            // TODO: Edit factory method of NetBigInteger
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }*/
        /*[PexFactoryMethod(typeof(NetBigInteger))]
        public static NetBigInteger Create(string value, int Base)
        {
            int res;
            PexAssume.IsTrue(int.TryParse(value, out res ));

            NetBigInteger netBigInteger = new NetBigInteger(value, Base);
            return netBigInteger;

            // TODO: Edit factory method of NetBigInteger
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }*/
        [PexFactoryMethod(typeof(NetBigInteger))]
        public static NetBigInteger Create(string value)
        {
            int res;
            PexAssume.IsTrue(int.TryParse(value, out res));

            NetBigInteger netBigInteger = new NetBigInteger(value);
            return netBigInteger;

            // TODO: Edit factory method of NetBigInteger
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }

       /* [PexFactoryMethod(typeof(NetBigInteger))]
        public static NetBigInteger Create(
            string str_s,
            int radix_i,
            int m_numBits_i1,
            int m_sign_i2,
            int[] m_magnitude_ints,
            int m_numBitLength_i3,
            long m_quote_l
        )
        {
            NetBigInteger netBigInteger = new NetBigInteger(str_s, radix_i);
            netBigInteger.m_numBits = m_numBits_i1;
            netBigInteger.m_sign = m_sign_i2;
            netBigInteger.m_magnitude = m_magnitude_ints;
            netBigInteger.m_numBitLength = m_numBitLength_i3;
            netBigInteger.m_quote = m_quote_l;
            return netBigInteger;

            // TODO: Edit factory method of NetBigInteger
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }*/


    }
}
