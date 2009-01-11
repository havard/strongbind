namespace OX.Strongbind
{
    /// <summary>
    /// A binding pair is a state object holding an object instance and a property name.
    /// The binding pair is used to represent either the source part or target part of
    /// a binding. It is used internally by Strongbind during binding declaration.
    /// </summary>
    public class BindingPair
    {
        private object instance;
        private string member;

        /// <summary>
        /// Gets the object part of the binding pair. This is the object that will
        /// be used as the source or target for a binding, depending on the context
        /// the binding pair is used in.
        /// </summary>
        public object Object
        {
            get { return instance; }
        }

        /// <summary>
        /// Gets the name of the property part of the binding pair. The property name
        /// defines which property on the <see cref="Object" /> that will be bound 
        /// when the binding is declared.
        /// </summary>
        public string Member
        {
            get { return member; }
        }

        /// <summary>
        /// Constructs a new binding pair.
        /// </summary>
        /// <param name="instance">The object part of the binding pair. 
        /// Whether the object is a source or target depends on the
        /// context it is used in.</param>
        /// <param name="member">The property name part of the binding pair.</param>
        public BindingPair(object instance, string member)
        {
            this.instance = instance;
            this.member = member;
        }
    }
}
