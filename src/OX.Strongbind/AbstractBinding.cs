namespace OX.Strongbind
{
    /// <summary>
    /// The base class for all representations of bindings used by Strongbind.
    /// An abstract binding defines a pairing of a source binding pair 
    /// and a target binding pair that together
    /// </summary>
    public abstract class AbstractBinding
    {
        private BindingPair source;
        private BindingPair target;
        private BindingPairHolder bindingPairHolder;

        /// <summary>
        /// Constructs a new abstract binding.
        /// </summary>
        /// <param name="bindingPairHolder">The binding pair holder to use for the binding.</param>
        protected AbstractBinding(BindingPairHolder bindingPairHolder)
        {
            this.bindingPairHolder = bindingPairHolder;
        }

        internal BindingPairHolder BindingPairHolder
        {
            get { return bindingPairHolder; }
        }

        internal BindingPair Source
        {
            get { return source; }
            set { source = value; }
        }

        internal BindingPair Target
        {
            get { return target; }
            set { target = value; }
        }

        /// <summary>
        /// Returns the target of the binding as an <see cref="System.Windows.Forms.IBindableComponent" />.
        /// Used internally for convenience during binding declaration.
        /// </summary>
        protected System.Windows.Forms.IBindableComponent BindableTarget
        {
            get { return (System.Windows.Forms.IBindableComponent)target.Object; }
        }

        /// <summary>
        /// Constructs a new abstract binding.
        /// </summary>
        protected AbstractBinding()
        {
        }
    }
}
