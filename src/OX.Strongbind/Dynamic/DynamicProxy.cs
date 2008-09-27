using Castle.DynamicProxy;
namespace OX.Strongbind.Dynamic
{
    internal static class DynamicProxy
    {
        public static T For<T>(T instance)
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
