namespace OX.Strongbind
{
    using OX.Strongbind.Dynamic;
    using OX.Strongbind.Remoting;
    using System;

    /// <summary>
    /// The proxy factory takes care of creating proxies for the given binding scope.
    /// </summary>
    internal class ProxyFactory : IDisposable
    {
        private DynamicProxy dynamicProxy;
        private RemotingProxy remotingProxy;

        internal ProxyFactory(IBindingScope bindingScope, BindingPairHolder bindingPairHolder)
        {
            dynamicProxy = new DynamicProxy(bindingScope, bindingPairHolder);
            remotingProxy = new RemotingProxy(bindingScope, bindingPairHolder);
        }

        /// <summary>
        /// Creates a new proxy for the given instance.
        /// </summary>
        /// <typeparam name="T">The type of the instance to create a proxy for.</typeparam>
        /// <param name="instance">The instance to create a proxy for.</param>
        /// <returns>A new proxy for the given instance.</returns>
        public T CreateProxy<T>(T instance)
        {
            // TODO: The proxy type should be configurable
            if (instance is MarshalByRefObject)
                return remotingProxy.For(instance);
            else
                return dynamicProxy.For(instance);
        }

        #region IDisposable Members

        public void Dispose()
        {
            remotingProxy.Dispose();
        }

        #endregion
    }
}
