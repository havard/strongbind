namespace OX.Strongbind.Remoting
{
    using System.Runtime.Remoting.Messaging;
    using System.Runtime.Remoting.Channels;
    using System.IO;
    using System;

    internal class InterceptingServerChannelSink : IServerChannelSink
    {
        private IServerChannelSink next;
        private RemotingProxy proxy;
        private BindingPairHolder bindingPairHolder;

        public InterceptingServerChannelSink(RemotingProxy proxy, BindingPairHolder bindingPairHolder)
        {
            this.proxy = proxy;
            this.bindingPairHolder = bindingPairHolder;
        }

        #region IServerChannelSink Members

        public void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public System.IO.Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public IServerChannelSink NextChannelSink
        {
            get { return next; }
            set { next = value; }
        }

        public ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, out IMessage responseMsg, out ITransportHeaders responseHeaders, out Stream responseStream)
        {
            if (requestMsg is MethodCall)
            {
                MethodCall call = (MethodCall)requestMsg;
                if (MethodMatchHelper.IsGetter(call.MethodBase))
                {
                    string identity = call.Uri.Substring(call.Uri.LastIndexOf('/') + 1);
                    string propertyName = MethodMatchHelper.PropertyNameFromGetter(call.MethodBase);

                    bindingPairHolder.DeclareBindingPair(proxy.RemotedObjects[identity], propertyName);
                }
            }
            return NextChannelSink.ProcessMessage(sinkStack, requestMsg, requestHeaders, requestStream, out responseMsg, out responseHeaders, out responseStream);
        }

        #endregion

        #region IChannelSinkBase Members

        public System.Collections.IDictionary Properties
        {
            get { return null; }
        }

        #endregion
    }
}
