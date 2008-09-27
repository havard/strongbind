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

    internal static class RemotingProxy
    {
        static readonly string CHANNEL_NAME = Guid.NewGuid().ToString();
        public static Dictionary<string, MarshalByRefObject> RemotedObjects;

        static RemotingProxy()
        {
            RemotedObjects = new Dictionary<string, MarshalByRefObject>();

            IServerChannelSinkProvider provider = new InteceptingServerChannelSinkProvider();
            IpcServerChannel serverChannel = new IpcServerChannel(CHANNEL_NAME, CHANNEL_NAME, provider);
            
            //IServerChannelSink sink = ChannelServices.CreateServerChannelSinkChain(provider, serverChannel);
            ChannelServices.RegisterChannel(serverChannel, true);
            serverChannel.StartListening(null);

            IpcChannel clientChannel = new IpcChannel();
            ChannelServices.RegisterChannel(clientChannel, true);
            
        }
        
        static string Create<T>(T control)
        {
            if (!(control is MarshalByRefObject))
                throw new InvalidOperationException("Object must be a MarshalByRefObject");
            string identity = Guid.NewGuid().ToString();
            RemotedObjects.Add(identity, control as MarshalByRefObject);
            RemotingConfiguration.RegisterWellKnownServiceType(control.GetType(), identity, WellKnownObjectMode.Singleton);
            return identity;
        }

        static T Get<T>(string identity)
        {            
            T remote = (T)Activator.GetObject(typeof(T), string.Format("ipc://{0}/{1}", CHANNEL_NAME, identity));
            return remote;
        }

        public static T For<T>(T instance)
        {
            string identity = Create(instance);
            return Get<T>(identity);
        }
    }
}
