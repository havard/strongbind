namespace OX.Strongbind
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// This class represents a complete binding from a property 
    /// on the binding source to a property on the binding target. 
    /// It exposes functionality to set properties on the binding 
    /// through various methods or hook on to events occuring
    /// on the underlying binding.
    /// </summary>
    public class CompleteBinding : AbstractBinding
    {
        private PartialBinding partialBinding;

        /// <summary>
        /// The underlying binding between the source and target.
        /// </summary>
        public Binding Binding
        {
            get { return BindableTarget.DataBindings[Target.Member]; }
        }

        /// <summary>
        /// The underlying binding manager for the binding.
        /// </summary>
        public BindingManagerBase BindingManager
        {
            get { return BindableTarget.BindingContext[Source.Object, Source.Member]; }
        }

        /// <summary>
        /// Constructs a new complete binding.
        /// </summary>
        /// <param name="partialBinding">The partial binding to construct a binding from. See <see cref="PartialBinding" /> and <see cref="BindingScope.CreateSource" />.</param>
        internal CompleteBinding(PartialBinding partialBinding)
            : base(partialBinding.BindingPairHolder)
        {
            this.partialBinding = partialBinding;

            Source = partialBinding.Source;
            ConsumeTargetAndBind();
        }

        private void ConsumeTargetAndBind()
        {
            Target = BindingPairHolder.ConsumeBindingPair();

            if (Target == null)
                throw new InvalidOperationException("Target property was not successfully declared. Verify that the target has been created using BindingScope.CreateTarget, and that the target type used during that declaration is either an interface type, a concrete type containing only virtual properties, or a type implementing MarshalByRefObject.");

            BindableTarget.DataBindings.Add(Target.Member, Source.Object, Source.Member);
        }

        /// <summary>
        /// Adds another binding from the source to the given target.
        /// </summary>
        /// <param name="propertyValue">The target property to bind to.</param>
        public CompleteBinding And(object propertyValue)
        {
            return new CompleteBinding(partialBinding);
        }

        /// <summary>
        /// Sets the object to be used in the target when the source
        /// contains a System.DBNull value.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public CompleteBinding WithNullValue(object value)
        {
            Binding.NullValue = value;
            return this;
        }

        /// <summary>
        /// Sets the update mode for the source of the binding, i.e. when
        /// changes in the binding target are propagated to the source.
        /// </summary>
        /// <param name="value">The <see cref="DataSourceUpdateMode" /> to use for the source.</param>
        public CompleteBinding WithSourceUpdateMode(DataSourceUpdateMode value)
        {
            Binding.DataSourceUpdateMode = value;
            return this;
        }

        /// <summary>
        /// Sets the update mode for the target of the binding, i.e. when
        /// changes in the binding source are propagated to the target.
        /// </summary>
        /// <param name="value">The <see cref="ControlUpdateMode" /> to use for the target.</param>
        public CompleteBinding WithTargetUpdateMode(ControlUpdateMode value)
        {
            Binding.ControlUpdateMode = value;
            return this;
        }

        /// <summary>
        /// Sets a format provider that provides custom formatting.
        /// </summary>
        /// <param name="value">The <see cref="IFormatProvider" /> to use.</param>
        public CompleteBinding WithFormatProvider(IFormatProvider value)
        {
            Binding.FormatInfo = value;
            return this;
        }

        /// <summary>
        /// Sets the format specifier characters that determines how the value 
        /// from the binding source is to be displayed in the target.
        /// </summary>
        /// <param name="value">The format specification to use.</param>
        public CompleteBinding WithFormatString(string value)
        {
            Binding.FormatString = value;
            return this;
        }

        /// <summary>
        /// Enables or disables type conversion and formatting for the binding.
        /// </summary>
        /// <param name="value"><value>true</value> if formatting should be enabled, 
        /// <value>false</value> otherwise.</param>
        public CompleteBinding WithFormattingEnabled(bool value)
        {
            Binding.FormattingEnabled = value;
            return this;
        }

        /// <summary>
        /// Sets the position in the underlying list that the binding target is bound to.
        /// </summary>
        /// <param name="value">The position to set.</param>
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
