using NUnit.Framework;
using System.Windows.Forms;
using System;
using OX.Strongbind.Remoting;

namespace OX.Strongbind.Tests
{
    [TestFixture]
    public class RemotingProxyTest
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
        public void TestRemotingProxyForWebBrowser() { TestRemotingProxyFor<WebBrowser>(); }
        
        private void TestRemotingProxyFor<T>() where T : Control, new()
        {
            T t = new T();
            T proxy = RemotingProxy.For(t);

            proxy.Name = "foo";
            Assert.AreEqual("foo", proxy.Name);

            // Check binding pair holder
            BindingPair pair = BindingPairHolder.ConsumeBindingPair();
            Assert.AreSame(t, pair.Object);
            Assert.AreEqual("Name", pair.Member);

            // Test remoting proxy object registry
            Assert.IsTrue(RemotingProxy.RemotedObjects.ContainsValue(t));
        }
    }
}
