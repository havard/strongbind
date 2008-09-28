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
        readonly internal Dictionary<string, MarshalByRefObject> RemotedObjects;
        readonly string channelName;
        readonly IpcChannel clientChannel;
        readonly IpcServerChannel serverChannel;

        public RemotingProxy()
        {
            RemotedObjects = new Dictionary<string, MarshalByRefObject>();

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
            return Create(instance);
        }

        public void Dispose()
        {
            ClearRemotedObjects();
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
    }
}
