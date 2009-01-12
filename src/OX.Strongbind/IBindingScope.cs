using System;
namespace OX.Strongbind
{
    /// <summary>
    /// Represents a scope in which bindings can be
    /// declared.
    /// </summary>
    public interface IBindingScope : IDisposable
    {
        /// <summary>
        /// Creates a new binding source, i.e. an object
        /// that can be used as the source for bindings.
        /// </summary>
        /// <typeparam name="T">The type of the binding source. Using an interface is recommended. 
        /// If the type is a concrete class containing non-virtual properties, the class should 
        /// inherit <see cref="MarshalByRefObject" />.</typeparam>
        /// <param name="instance">The instance to use as the binding source. 
        /// Using an instance that is declared as an interface type is recommended.
        /// If the declared type is a concrete class containing non-virtual properties, the class should 
        /// inherit <see cref="MarshalByRefObject" />.</param>
        /// <returns>A binding source ready for binding.</returns>
        T CreateSource<T>(T instance);

        /// <summary>
        /// Creates a new binding target. A binding target can be used as the target for bindings.
        /// The target is usually a Windows Forms control, but can be any 
        /// <see cref="System.Windows.Forms.IBindableComponent" />.
        /// </summary>
        /// <typeparam name="T">The type of the binding target. This must be a 
        /// <see cref="System.Windows.Forms.IBindableComponent" />.</typeparam>
        /// <param name="instance">The instance to use as the binding target.</param>
        /// <returns>A binding target ready for use.</returns>
        T CreateTarget<T>(T instance) where T : System.Windows.Forms.IBindableComponent, new();

        /// <summary>
        /// Initializes a new binding from the given property on the binding source.
        /// </summary>
        /// <param name="propertyValue">The source property for the binding.</param>
        PartialBinding Bind(object propertyValue);

        /// <summary>
        /// Indicates if the binding scope has been disposed.
        /// </summary>
        bool IsDisposed { get; }
    }
}
