using System;

namespace OX.Strongbind
{
    public class PartialBinding : AbstractBinding
    {
        internal PartialBinding(BindingPair source)
            : base()
        {
            Source = source;
        }

        public CompleteBinding To(object propertyValue)
        {
            Target = BindingPairHolder.ConsumeBindingPair();

            if(Target == null)
                throw new InvalidOperationException("Target property was not successfully declared. Verify that the target property is virtual.");
            BindableTarget.DataBindings.Add(Target.Member, Source.Object, Source.Member);

            return new CompleteBinding(Source, Target);
        }
    }

}
