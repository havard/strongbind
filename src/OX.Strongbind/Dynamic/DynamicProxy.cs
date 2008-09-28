using Castle.DynamicProxy;
namespace OX.Strongbind.Dynamic
{
    internal class DynamicProxy
    {
        public T For<T>(T instance)
        {
            DynamicProxyInterceptor interceptor = new DynamicProxyInterceptor(instance);
            ProxyGenerator generator = new ProxyGenerator();
            if (typeof(T).IsInterface)
                return generator.CreateInterfaceProxyWithTarget<T>(instance, interceptor);
            else
                return generator.CreateClassProxy<T>(interceptor);
        }
    }
}
