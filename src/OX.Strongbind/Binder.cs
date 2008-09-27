using System;

namespace OX.Strongbind
{
    public static class Binder
    {
        public static PartialBinding Bind(object propertyValue)
        {
            // Don't care what gets sent in, but consume binding pair
            BindingPair source = BindingPairHolder.ConsumeBindingPair();
            if (source == null)
                throw new ArgumentException("Source property was not successfully declared. Verify that your bindable source meets the requirements for strongly typed binding.");
            return new PartialBinding(source);
        }
    }
}
