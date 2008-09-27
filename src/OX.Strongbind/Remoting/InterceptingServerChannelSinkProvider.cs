namespace OX.Strongbind.Remoting
{
    using System.Runtime.Remoting.Channels;

    internal class InteceptingServerChannelSinkProvider : IServerChannelSinkProvider
    {
        private IServerChannelSinkProvider next;

        #region IServerChannelSinkProvider Members

        public IServerChannelSink CreateSink(IChannelReceiver channel)
        {
            InterceptingServerChannelSink g = new InterceptingServerChannelSink();
            BinaryServerFormatterSink formatter = new BinaryServerFormatterSink(BinaryServerFormatterSink.Protocol.Other, g, channel);

            if (next != null)
                g.NextChannelSink = next.CreateSink(channel);

            return formatter;
        }

        public void GetChannelData(IChannelDataStore channelData)
        {
        }

        public IServerChannelSinkProvider Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        #endregion
    }
}
