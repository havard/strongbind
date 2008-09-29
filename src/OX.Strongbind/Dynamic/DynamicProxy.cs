namespace OX.Strongbind.Dynamic
{
    using Castle.DynamicProxy;
    using System;

    internal class DynamicProxy
    {
        private IBindingScope scope;

        public DynamicProxy(IBindingScope scope)
        {
            this.scope = scope;
        }

        public T For<T>(T instance)
        {
            ThrowIfScopeIsDisposed();

            DynamicProxyInterceptor interceptor = new DynamicProxyInterceptor(scope, instance);
            ProxyGenerator generator = new ProxyGenerator();
            if (typeof(T).IsInterface)
                return generator.CreateInterfaceProxyWithTarget<T>(instance, interceptor);
            else
                return generator.CreateClassProxy<T>(interceptor);
        }

        private void ThrowIfScopeIsDisposed()
        {
            if (scope.IsDisposed)
                throw new InvalidOperationException("Cannot create a proxy since the binding scope has been disposed.");
        }
    }
}
