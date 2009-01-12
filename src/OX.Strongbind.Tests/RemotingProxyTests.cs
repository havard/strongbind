namespace OX.Strongbind.Tests
{
    using NUnit.Framework;
    using System;
    using System.Reflection;
    using System.Windows.Forms;
    using OX.Strongbind.Remoting;
    

    [TestFixture]
    public class RemotingProxyTests
    {
        [Test]
        public void TestRemotingProxyForButton() { TestRemotingProxyFor<Button>(); }
        [Test]
        public void TestRemotingProxyForCheckBox() { TestRemotingProxyFor<CheckBox>(); }
        [Test]
        public void TestRemotingProxyForCheckedListBox() { TestRemotingProxyFor<CheckedListBox>(); }
        [Test]
        public void TestRemotingProxyForComboBox() { TestRemotingProxyFor<ComboBox>(); }
        [Test]
        public void TestRemotingProxyForDateTimePicker() { TestRemotingProxyFor<DateTimePicker>(); }
        [Test]
        public void TestRemotingProxyForLabel() { TestRemotingProxyFor<Label>(); }
        [Test]
        public void TestRemotingProxyForLinkLabel() { TestRemotingProxyFor<LinkLabel>(); }
        [Test]
        public void TestRemotingProxyForListBox() { TestRemotingProxyFor<ListBox>(); }
        [Test]
        public void TestRemotingProxyForListView() { TestRemotingProxyFor<ListView>(); }
        [Test]
        public void TestRemotingProxyForMaskedTextBox() { TestRemotingProxyFor<MaskedTextBox>(); }
        [Test]
        public void TestRemotingProxyForMonthCalendar() { TestRemotingProxyFor<MonthCalendar>(); }
        [Test]
        public void TestRemotingProxyForNumericUpDown() { TestRemotingProxyFor<NumericUpDown>(); }
        [Test]
        public void TestRemotingProxyForPictureBox() { TestRemotingProxyFor<PictureBox>(); }
        [Test]
        public void TestRemotingProxyForProgressBar() { TestRemotingProxyFor<ProgressBar>(); }
        [Test]
        public void TestRemotingProxyForPropertyGrid() { TestRemotingProxyFor<PropertyGrid>(); }
        [Test]
        public void TestRemotingProxyForRadioButton() { TestRemotingProxyFor<RadioButton>(); }
        [Test]
        public void TestRemotingProxyForRichTextBox() { TestRemotingProxyFor<RichTextBox>(); }
        [Test]
        public void TestRemotingProxyForTextBox() { TestRemotingProxyFor<TextBox>(); }
        [Test]
        public void TestRemotingProxyForTreeView() { TestRemotingProxyFor<TreeView>(); }
        [Test]
        [ExpectedException(typeof(TargetInvocationException))]
        public void TestRemotingProxyForWebBrowser() { TestRemotingProxyFor<WebBrowser>(); }

        class BindingScopeStub : IBindingScope
        {
            #region IBindingScope Members

            public T CreateSource<T>(T instance)
            {
                return default(T);
            }

            public T CreateTarget<T>(T instance) where T : IBindableComponent, new()
            {
                return default(T);
            }

            public bool IsDisposed
            {
                get { return false; }
            }

            public PartialBinding Bind(object propertyValue)
            {
                return null;
            }

            #endregion

            #region IDisposable Members

            public void Dispose()
            {
            }

            #endregion
        }
        private void TestRemotingProxyFor<T>() where T : Control, new()
        {
            BindingPairHolder bindingPairHolder = new BindingPairHolder();
            using (RemotingProxy generator = new RemotingProxy(new BindingScopeStub(), bindingPairHolder))
            {
                T t = new T();
                T proxy = generator.For(t);

                proxy.Name = "foo";
                Assert.AreEqual("foo", proxy.Name);

                // Check binding pair holder
                BindingPair pair = bindingPairHolder.ConsumeBindingPair();
                Assert.AreSame(t, pair.Object);
                Assert.AreEqual("Name", pair.Member);

                // Test remoting proxy object registry
                Assert.IsTrue(generator.RemotedObjects.ContainsValue(t));
            }
        }
    }
}
