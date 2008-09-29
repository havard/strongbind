namespace OX.Strongbind.Dynamic
{
    using Castle.Core.Interceptor;
    using System; 

    internal class DynamicProxyInterceptor : IInterceptor
    {
        private IBindingScope scope;
        private object proxied;

        public DynamicProxyInterceptor(IBindingScope scope, object original)
        {
            this.scope = scope;
            proxied = original;
        }

        #region IInterceptor Members

        public void Intercept(IInvocation invocation)
        {
            ThrowIfScopeIsDisposed();

            if (!MethodMatchHelper.IsGetter(invocation.Method))
                return;

            invocation.ReturnValue = invocation.Method.Invoke(proxied, invocation.Arguments);

            string propertyName = MethodMatchHelper.PropertyNameFromGetter(invocation.Method);
            BindingPairHolder.DeclareBindingPair(proxied, propertyName);
        }

        #endregion

        private void ThrowIfScopeIsDisposed()
        {
            if (scope.IsDisposed)
                throw new InvalidOperationException("Cannot create a proxy since the binding scope has been disposed.");
        }
    }
}
