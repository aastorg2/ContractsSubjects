using System;

namespace NetOutgoingMessage
{
	internal abstract class SenderChannelBase
	{
		internal abstract NetSendResult Send(float now, NetOutgoingMessage message);
		internal abstract void SendQueuedMessages(float now);
		internal abstract void Reset();
	}
}
