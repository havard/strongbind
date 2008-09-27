namespace OX.Strongbind
{
    public abstract class AbstractBinding
    {
        private BindingPair source;
        private BindingPair target;

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

        protected System.Windows.Forms.IBindableComponent BindableTarget
        {
            get { return (System.Windows.Forms.IBindableComponent)target.Object; }
        }

        protected AbstractBinding()
        {
        }
    }
}
