using System;
using OX.Strongbind.Dynamic;
using OX.Strongbind.Remoting;


namespace OX.Strongbind
{
    public class BindingScope : IDisposable
    {
        private DynamicProxy dynamicProxy;
        private RemotingProxy remotingProxy;

        public BindingScope()
        {
            dynamicProxy = new DynamicProxy();
            remotingProxy = new RemotingProxy();
        }

        public T CreateSource<T>(T instance)
        {
            return CreateProxy(instance);
        }

        public T CreateTarget<T>(T instance) where T : System.Windows.Forms.IBindableComponent, new()
        {
            instance.DataBindings.Clear();
            return CreateProxy(instance);
        }

        public void Dispose()
        {
            remotingProxy.Dispose();
        }

        private T CreateProxy<T>(T instance)
        {
            if (instance is MarshalByRefObject)
                return remotingProxy.For(instance);
            else
                return dynamicProxy.For(instance);
        }
    }
}
