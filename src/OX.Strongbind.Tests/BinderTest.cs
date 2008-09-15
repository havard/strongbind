using System.Windows.Forms;
using NUnit.Framework;


namespace OX.Strongbind.Tests
{
    [TestFixture]
    public class BinderTest
    {        
        [Test]
        public void TestTwoWayBindingWithPropertyChangeNotification()
        {
            IBusinessObject businessObject = new BusinessObject();
            businessObject.Name = "Foo";

            CheckBox checkbox = new CheckBox();
            checkbox.CreateControl();
            checkbox.BindingContext = new BindingContext();

            IBusinessObject bindableSource = Bindable.Source(businessObject);
            CheckBox bindableTarget = Bindable.Target(checkbox);

            Binder.Bind(bindableSource.Name).To(bindableTarget.Text);

            Assert.AreEqual(1, checkbox.DataBindings.Count);

            Assert.AreSame(businessObject, checkbox.DataBindings[0].DataSource);

            Assert.AreEqual(businessObject.Name, checkbox.Text);

            checkbox.Text = "Bar";
            checkbox.DataBindings[0].WriteValue();

            Assert.AreEqual(checkbox.Text, businessObject.Name);

            businessObject.Name = "Baz";

            Assert.AreEqual(businessObject.Name, checkbox.Text);
        }

        public void TestOneWayBinding()
        {
        }
    }
}
