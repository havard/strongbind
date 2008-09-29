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
        internal PartialBinding(BindingPair source)
            : base()
        {
            Source = source;
        }

        /// <summary>
        /// Creates a binding from the source to the given target.
        /// </summary>
        /// <param name="propertyValue">The target property to bind to.</param>
        public CompleteBinding To(object propertyValue)
        {
            Target = BindingPairHolder.ConsumeBindingPair();

            if(Target == null)
                throw new InvalidOperationException("Target property was not successfully declared. Verify that the target has been created using BindingScope.CreateTarget, and that the target type used during that declaration is either an interface type, a concrete type containing only virtual properties, or a type implementing MarshalByRefObject.");
            BindableTarget.DataBindings.Add(Target.Member, Source.Object, Source.Member);

            return new CompleteBinding(Source, Target);
        }
    }

}
