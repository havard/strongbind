using System;

namespace OX.Strongbind
{
    /// <summary>
    /// Represents a partial binding from a binding source to a binding target.
    /// A partial binding contains only the source part of the binding,
    /// and can be used to complete the binding by specifying a target using 
    /// its <see cref="To" /> method.
    /// </summary>
    public class PartialBinding : AbstractBinding
    {
        /// <summary>
        /// Constructs a new partial binding.
        /// </summary>
        /// <param name="bindingPairHolder">The binding pair holder to consume from.</param>
        internal PartialBinding(BindingPairHolder bindingPairHolder)
            : base(bindingPairHolder)
        {
            ConsumeSource();
        }

        private void ConsumeSource()
        {
            Source = BindingPairHolder.ConsumeBindingPair();
            if (Source == null)
                throw new ArgumentException("Source property was not successfully declared. Verify that the target has been created using BindingScope.CreateTarget, and that the target type used during that declaration is either an interface type, a concrete type containing only virtual properties, or a type implementing MarshalByRefObject.");
        }

        /// <summary>
        /// Creates a binding from the source to the given target.
        /// </summary>
        /// <param name="propertyValue">The target property to bind to.</param>
        public CompleteBinding To(object propertyValue)
        {
            return new CompleteBinding(this);
        }
    }

}
