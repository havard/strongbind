namespace OX.Strongbind
{
    using System;

    /// <summary>
    /// Declares bindings through a single method <see cref="Bind"/>.
    /// </summary>
    public static class Binder
    {
        /// <summary>
        /// Initializes a new binding from the given property on the binding source.
        /// </summary>
        /// <param name="propertyValue">The source property for the binding.</param>
        public static PartialBinding Bind(object propertyValue)
        {
            // Don't care what gets sent in, but consume binding pair
            BindingPair source = BindingPairHolder.ConsumeBindingPair();
            if (source == null)
                throw new ArgumentException("Source property was not successfully declared. Verify that the target has been created using BindingScope.CreateTarget, and that the target type used during that declaration is either an interface type, a concrete type containing only virtual properties, or a type implementing MarshalByRefObject.");
            return new PartialBinding(source);
        }
    }
}
