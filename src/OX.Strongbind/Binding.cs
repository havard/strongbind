namespace OX.Strongbind
{
    public class Binding
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

        internal Binding(BindingPair source)
        {
            this.source = source;
        }

        public void To(object value)
        {
            target = BindingPairHolder.ConsumeBindingPair();

            System.Windows.Forms.IBindableComponent c = (System.Windows.Forms.IBindableComponent)target.Object;

            c.DataBindings.Add(target.Member, source.Object, source.Member);
        }
    }
}
