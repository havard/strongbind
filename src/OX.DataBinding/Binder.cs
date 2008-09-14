using System;
using System.Collections.Generic;
using System.Text;

namespace OX.DataBinding
{
    public static class Binder
    {
        public static Binding Bind(object value)
        {
            // Don't care what gets sent in, but consume binding pair
            BindingPair source = BindingPairHolder.ConsumeBindingPair();
            if (source == null)
                throw new InvalidOperationException("No source binding has been declared.");
            return new Binding(source);
        }
    }
}
