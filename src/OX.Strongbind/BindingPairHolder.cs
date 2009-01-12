namespace OX.Strongbind
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Holds binding pairs for consumption by the Strongbind
    /// framework. Binding pairs can be eithar sources or targets,
    /// for the binding, depending on the context in which they are 
    /// consumed by Strongbind. If a binding pair is consumed by
    /// a call to <see cref="BindingScope.Bind" />, the binding pair
    /// will become a source for the binding. If a binding pair
    /// is consumed by a call to <see cref="PartialBinding.To" />
    /// or <see cref="CompleteBinding.And" />, the binding pair
    /// will become a target for the binding.
    /// 
    /// To declare bindings, see the <see cref="BindingScope" />
    /// class.
    /// </summary>
    public class BindingPairHolder
    {
        private List<BindingPair> bindingPairs;

        internal BindingPairHolder()
        {
            bindingPairs = new List<BindingPair>();
        }

        internal BindingPair ConsumeBindingPair()
        {
            object source = null;
            StringBuilder bindingPath = new StringBuilder();

            foreach (BindingPair pair in bindingPairs)
            {
                if (source == null)
                    source = pair.Object;
                bindingPath.Append(pair.Member);
                bindingPath.Append('.');
            }

            if(source == null)
                return null;

            bindingPairs.Clear();

            bindingPath.Remove(bindingPath.Length - 1, 1);
            return new BindingPair(source, bindingPath.ToString());
        }

        /// <summary>
        /// Declares a new binding pair. This method is called
        /// by the proxies when calls to property getters are 
        /// intercepted. 
        /// </summary>
        /// <param name="instance">The object part of the binding pair.</param>
        /// <param name="member">The property name part of the binding pair.</param>
        internal void DeclareBindingPair(object instance, string member)
        {
            bindingPairs.Add(new BindingPair(instance, member));
        }
    }
}
