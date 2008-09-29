namespace OX.Strongbind
{
    using System;
    using System.Windows.Forms;
    using OX.Strongbind.Dynamic;
    using OX.Strongbind.Remoting;    

    /// <summary>
    /// Represents a scope in which bindings can be
    /// declared using <see cref="Binder" />.
    /// </summary>
    public class BindingScope : IBindingScope
    {
        private DynamicProxy dynamicProxy;
        private RemotingProxy remotingProxy;
        private bool disposed;

        /// <summary>
        /// Initializes a new binding scope in which
        /// bindings can be declared.
        /// </summary>
        public BindingScope()
        {
            dynamicProxy = new DynamicProxy(this);
            remotingProxy = new RemotingProxy(this);
            disposed = false;
        }

        /// <summary>
        /// Creates a new binding source, i.e. an object
        /// that can be used as the source for bindings
        /// declared by <see cref="Binder"/>.
        /// </summary>
        /// <typeparam name="T">The type of the binding source. Using an interface is recommended. 
        /// If the type is a concrete class containing non-virtual properties, the class should 
        /// inherit <see cref="MarshalByRefObject" />.</typeparam>
        /// <param name="instance">The instance to use as the binding source. 
        /// Using an instance that is declared as an interface type is recommended.
        /// If the declared type is a concrete class containing non-virtual properties, the class should 
        /// inherit <see cref="MarshalByRefObject" />.</param>
        /// <returns>A binding source ready for binding using <see cref="Binder.Bind"/>.</returns>
        public T CreateSource<T>(T instance)
        {
            return CreateProxy(instance);
        }

        /// <summary>
        /// Creates a new binding target. A binding target can be used as the target for bindings
        /// declared by <see cref="Binder.Bind" />. The target is usually a Windows Forms control,
        /// but can be any <see cref="IBindableComponent" />.
        /// </summary>
        /// <typeparam name="T">The type of the binding target. This must be a <see cref="IBindableComponent" />.</typeparam>
        /// <param name="instance">The instance to use as the binding target.</param>
        /// <returns>A binding target ready for use with <see cref="Binder"/>.</returns>
        public T CreateTarget<T>(T instance) where T : IBindableComponent, new()
        {
            instance.DataBindings.Clear();
            return CreateProxy(instance);
        }

        /// <summary>
        /// Disposes the binding scope. Must be called to free
        /// up resources used during binding declaration.
        /// </summary>
        public void Dispose()
        {
            remotingProxy.Dispose();
            disposed = true;
        }

        public bool IsDisposed
        {
            get { return disposed; }
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
