namespace OX.Strongbind.Dynamic
{
    using Castle.DynamicProxy;
    using System;

    internal class DynamicProxy
    {
        private IBindingScope scope;
        private BindingPairHolder bindingPairHolder;

        public DynamicProxy(IBindingScope scope, BindingPairHolder bindingPairHolder)
        {
            this.scope = scope;
            this.bindingPairHolder = bindingPairHolder;
        }

        public T For<T>(T instance)
        {
            return (T)For(typeof(T), instance);
        }

        public object For(Type instanceType, object instance)
        {
            ThrowIfScopeIsDisposed();

            DynamicProxyInterceptor interceptor = new DynamicProxyInterceptor(scope, instance, bindingPairHolder);
            ProxyGenerator generator = new ProxyGenerator();

            if(instanceType.IsInterface)
                return generator.CreateInterfaceProxyWithTarget(instanceType, instance, interceptor);
            else
                return generator.CreateClassProxy(instanceType, interceptor);
        }

        private void ThrowIfScopeIsDisposed()
        {
            if (scope.IsDisposed)
                throw new InvalidOperationException("Cannot create a proxy since the binding scope has been disposed.");
        }
    }
}
