namespace OX.Strongbind.Remoting
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Remoting;
    using System.Runtime.Remoting.Channels;
    using System.Runtime.Remoting.Channels.Ipc;
    using System.Windows.Forms;    

    internal class RemotingProxy : IDisposable
    {        
        private readonly Dictionary<string, MarshalByRefObject> remotedObjects;
        private readonly string channelName;
        private readonly IpcChannel clientChannel;
        private readonly IpcServerChannel serverChannel;
        private readonly IBindingScope scope;

        public RemotingProxy(IBindingScope scope)
        {
            this.scope = scope;

            remotedObjects = new Dictionary<string, MarshalByRefObject>();

            channelName = Guid.NewGuid().ToString();

            IServerChannelSinkProvider provider = new InterceptingServerChannelSinkProvider(this);
            serverChannel = new IpcServerChannel(channelName, channelName, provider);

            //IServerChannelSink sink = ChannelServices.CreateServerChannelSinkChain(provider, serverChannel);
            ChannelServices.RegisterChannel(serverChannel, true);
            serverChannel.StartListening(null);

            clientChannel = new IpcChannel();
            ChannelServices.RegisterChannel(clientChannel, true);
        }
        
        public T For<T>(T instance)
        {
            ThrowIfScopeIsDisposed();
            return Create(instance);
        }

        public void Dispose()
        {
            ClearRemotedObjects();
        }

        internal Dictionary<string, MarshalByRefObject> RemotedObjects
        {
            get { return remotedObjects; }
        }
        
        private T Create<T>(T control)
        {
            if (!(control is MarshalByRefObject))
                throw new InvalidOperationException("Object must be a MarshalByRefObject");
            string identity = Guid.NewGuid().ToString();
            MarshalByRefObject obj = control as MarshalByRefObject;
            RemotedObjects.Add(identity, obj);
            //RemotingServices.Marshal(obj, identity);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(T), identity, WellKnownObjectMode.Singleton);

            T remote = (T)Activator.GetObject(typeof(T), string.Format("ipc://{0}/{1}", channelName, identity));
            return remote;
        }

        private void ClearRemotedObjects()
        {
            ChannelServices.UnregisterChannel(clientChannel);

            serverChannel.StopListening(null);
            ChannelServices.UnregisterChannel(serverChannel);
        }

        private void ThrowIfScopeIsDisposed()
        {
            if (scope.IsDisposed)
                throw new InvalidOperationException("Cannot create a proxy since the binding scope has been disposed.");
        }
    }
}
