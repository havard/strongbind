using Castle.Core.Interceptor;

namespace OX.Strongbind.Dynamic
{
    internal class DynamicProxyInterceptor : IInterceptor
    {
        private object proxied;

        public DynamicProxyInterceptor(object original)
        {
            proxied = original;
        }

        #region IInterceptor Members

        public void Intercept(IInvocation invocation)
        {
            if (!MethodMatchHelper.IsGetter(invocation.Method))
                return;

            invocation.ReturnValue = invocation.Method.Invoke(proxied, invocation.Arguments);

            string propertyName = MethodMatchHelper.PropertyNameFromGetter(invocation.Method);
            BindingPairHolder.DeclareBindingPair(proxied, propertyName);
        }

        #endregion
    }
}
