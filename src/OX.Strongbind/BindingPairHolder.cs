namespace OX.Strongbind
{
    /// <summary>
    /// Holds binding pairs for consumption by the Strongbind
    /// framework. Binding pairs can be eithar sources or targets,
    /// for the binding, depending on the context in which they are 
    /// consumed by Strongbind. If a binding pair is consumed by
    /// a call to <see cref="Binder.Bind" />, the binding pair
    /// will become a source for the binding. If a binding pair
    /// is consumed by a call to <see cref="PartialBinding.To" />
    /// or <see cref="CompleteBinding.And" />, the binding pair
    /// will become a target for the binding.
    /// 
    /// To declare bindings, see the <see cref="BindingScope" />
    /// and <see cref="Binder"/> classes.
    /// </summary>
    public static class BindingPairHolder
    {
        private static object syncroot = new object();
        private static BindingPair currentPair;

        /// <summary>
        /// Consumes any currently held binding pair.
        /// </summary>
        /// <returns>The consumed binding pair.</returns>
        public static BindingPair ConsumeBindingPair()
        {
            BindingPair toReturn = null;
            lock (syncroot)
            {
                toReturn = currentPair;
                currentPair = null;
            }
            return toReturn;
        }

        /// <summary>
        /// Declares a new binding pair. This method is called
        /// by the proxies when calls to property getters are 
        /// intercepted. 
        /// </summary>
        /// <param name="instance">The object part of the binding pair.</param>
        /// <param name="member">The property name part of the binding pair.</param>
        public static void DeclareBindingPair(object instance, string member)
        {
            lock (syncroot)
            {
                currentPair = new BindingPair(instance, member);
            }
        }
    }
}
