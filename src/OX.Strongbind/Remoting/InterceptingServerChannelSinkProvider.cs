namespace OX.Strongbind.Remoting
{
    using System.Runtime.Remoting.Channels;

    internal class InterceptingServerChannelSinkProvider : IServerChannelSinkProvider
    {
        private IServerChannelSinkProvider next;
        private RemotingProxy proxy;
        private BindingPairHolder bindingPairHolder;

        public InterceptingServerChannelSinkProvider(RemotingProxy proxy, BindingPairHolder bindingPairHolder)
        {
            this.proxy = proxy;
            this.bindingPairHolder = bindingPairHolder;
        }

        #region IServerChannelSinkProvider Members

        public IServerChannelSink CreateSink(IChannelReceiver channel)
        {
            InterceptingServerChannelSink g = new InterceptingServerChannelSink(proxy, bindingPairHolder);
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
