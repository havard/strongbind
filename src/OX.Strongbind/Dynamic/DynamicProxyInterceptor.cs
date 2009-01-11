namespace OX.Strongbind.Dynamic
{
    using Castle.Core.Interceptor;
    using System; 

    internal class DynamicProxyInterceptor : IInterceptor
    {
        private IBindingScope scope;
        private object proxied;
        private BindingPairHolder bindingPairHolder;

        public DynamicProxyInterceptor(IBindingScope scope, object original, BindingPairHolder bindingPairHolder)
        {
            this.scope = scope;
            proxied = original;
            this.bindingPairHolder = bindingPairHolder;
        }

        #region IInterceptor Members

        public void Intercept(IInvocation invocation)
        {
            ThrowIfScopeIsDisposed();

            if (!MethodMatchHelper.IsGetter(invocation.Method))
                return;
            
            object returnValue = null;
            if(proxied != null)
                returnValue = invocation.Method.Invoke(proxied, invocation.Arguments);

            try
            {
                invocation.ReturnValue = new DynamicProxy(scope, bindingPairHolder).For(invocation.Method.ReturnType, returnValue);
            }
            catch
            {
                // Create a default instance
                try
                {
                    invocation.ReturnValue = Activator.CreateInstance(invocation.Method.ReturnType);
                }
                catch
                {
                    invocation.ReturnValue = null;
                }
            }

            string propertyName = MethodMatchHelper.PropertyNameFromGetter(invocation.Method);
            bindingPairHolder.DeclareBindingPair(proxied, propertyName);
        }

        #endregion

        private void ThrowIfScopeIsDisposed()
        {
            if (scope.IsDisposed)
                throw new InvalidOperationException("Cannot create a proxy since the binding scope has been disposed.");
        }
    }
}
