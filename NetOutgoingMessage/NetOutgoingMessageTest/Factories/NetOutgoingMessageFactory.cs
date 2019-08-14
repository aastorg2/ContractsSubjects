using System;
using Microsoft.Pex.Framework;
using NetOutgoingMessage;

namespace NetOutgoingMessage.Test.Factories
{
    /// <summary>A factory for Lidgren.Network.NetOutgoingMessage instances</summary>
    public static partial class NetOutgoingMessageFactory
    {
        /// <summary>A factory for Lidgren.Network.NetOutgoingMessage instances</summary>
        [PexFactoryMethod(typeof(NetOutgoingMessage))]
        public static NetOutgoingMessage Create([PexAssumeNotNull]string content, [PexAssumeNotNull]string appIdentifier, [PexAssumeNotNull]byte[] source)
        {
            PexAssume.IsTrue(!string.IsNullOrEmpty(appIdentifier));

            NetPeerConfiguration config = new NetPeerConfiguration(appIdentifier);
            NetPeer peer = new NetPeer(config);

            NetOutgoingMessage outM = peer.CreateMessage(content);
            outM.Write(source);
            return outM;
            // TODO: Edit factory method of NetOutgoingMessage
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
