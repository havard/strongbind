using System;
using System.Windows.Forms;

namespace OX.Strongbind
{
    public class CompleteBinding : AbstractBinding
    {
        public Binding Binding
        {
            get { return BindableTarget.DataBindings[Target.Member]; }
        }

        public BindingManagerBase BindingManager
        {
            get { return BindableTarget.BindingContext[Source.Object, Source.Member]; }
        }

        internal CompleteBinding(BindingPair source, BindingPair target)
            : base()
        {
            Source = source;
            Target = target;
        }

        public CompleteBinding And(object propertyValue)
        {
            BindingPair newTarget = BindingPairHolder.ConsumeBindingPair();
            if (newTarget == null)
                throw new InvalidOperationException("Target property was not successfully declared. Verify that the target property is virtual.");

            CompleteBinding newBinding = new CompleteBinding(Source, newTarget);
            if (newTarget.Object == Target.Object)
                BindableTarget.DataBindings.Add(newTarget.Member, Source.Object, Source.Member);
            else
                newBinding.BindableTarget.DataBindings.Add(newTarget.Member, Source.Object, Source.Member);
            return newBinding; 
        }

        public CompleteBinding WithNullValue(object value)
        {
            Binding.NullValue = value;
            return this;
        }

        public CompleteBinding WithSourceUpdateMode(DataSourceUpdateMode value)
        {
            Binding.DataSourceUpdateMode = value;
            return this;
        }

        public CompleteBinding WithTargetUpdateMode(ControlUpdateMode value)
        {
            Binding.ControlUpdateMode = value;
            return this;
        }

        public CompleteBinding WithFormatProvider(IFormatProvider value)
        {
            Binding.FormatInfo = value;
            return this;
        }

        public CompleteBinding WithFormatString(string value)
        {
            Binding.FormatString = value;
            return this;
        }

        public CompleteBinding WithFormattingEnabled(bool value)
        {
            Binding.FormattingEnabled = value;
            return this;
        }

        public CompleteBinding WithPosition(int value)
        {
            BindingManager.Position = value;
            return this;
        }

        #region Events

        public CompleteBinding OnFormattedBindingComplete(BindingCompleteEventHandler handler)
        {
            Binding.BindingComplete += handler;
            return this;
        }

        public CompleteBinding OnFormat(ConvertEventHandler handler)
        {
            Binding.Format += handler;
            return this;
        }

        public CompleteBinding OnParse(ConvertEventHandler handler)
        {
            Binding.Parse += handler;
            return this;
        }

        public CompleteBinding OnBindingComplete(BindingCompleteEventHandler handler)
        {
            BindingManager.BindingComplete += handler;
            return this;
        }

        public CompleteBinding OnCurrentChanged(EventHandler handler)
        {
            BindingManager.CurrentChanged += handler;
            return this;
        }

        public CompleteBinding OnCurrentItemChanged(EventHandler handler)
        {
            BindingManager.CurrentItemChanged += handler;
            return this;
        }

        public CompleteBinding OnDataError(BindingManagerDataErrorEventHandler handler)
        {
            BindingManager.DataError += handler;
            return this;
        }

        public CompleteBinding OnPositionChanged(EventHandler handler)
        {
            BindingManager.PositionChanged += handler;
            return this;
        }

        #endregion
    }
}
