namespace OX.Strongbind.Tests
{
    using NUnit.Framework;
    using System.Windows.Forms;
    using System.Drawing;

    [TestFixture]
    public class NavigationPathBindingTests
    {
        public class Range
        {
            private int min;
            private int max;
            public virtual int Min { get { return min; } set { min = value; } }
            public virtual int Max { get { return max; } set { max = value; } }
        }

        public class RangedObject
        {
            private Range validWithin;

            public virtual Range ValidWithin { get { return validWithin; } set { validWithin = value; } }
        }

        public class SizeContainer
        {
            private Size size;

            public virtual Size Size { get { return size; } set { size = value; } }
        }

        [Test]
        public void TestNavigationPathBindingToPropertyOnPropertyOnSource()
        {
            RangedObject obj = new RangedObject();
            obj.ValidWithin = new Range();
            NumericUpDown numericUpDown = new NumericUpDown();

            using (BindingScope binder = new BindingScope())
            {
                RangedObject source = binder.CreateSource(obj);
                NumericUpDown target = binder.CreateTarget(numericUpDown);

                binder.Bind(source.ValidWithin.Min).To(target.Minimum);
                binder.Bind(source.ValidWithin.Max).To(target.Maximum);
            }

            Assert.AreEqual("ValidWithin.Min", numericUpDown.DataBindings["Minimum"].BindingMemberInfo.BindingMember);
            Assert.AreEqual("ValidWithin", numericUpDown.DataBindings["Minimum"].BindingMemberInfo.BindingPath);
            Assert.AreEqual("Min", numericUpDown.DataBindings["Minimum"].BindingMemberInfo.BindingField);

            Assert.AreEqual("ValidWithin.Max", numericUpDown.DataBindings["Maximum"].BindingMemberInfo.BindingMember);
            Assert.AreEqual("ValidWithin", numericUpDown.DataBindings["Maximum"].BindingMemberInfo.BindingPath);
            Assert.AreEqual("Max", numericUpDown.DataBindings["Maximum"].BindingMemberInfo.BindingField);
        }

        [Test]
        public void TestNavigationPathBindingToPropertyOnPropertyOnSourceWithNullObjectInPath()
        {
            RangedObject obj = new RangedObject();
            NumericUpDown numericUpDown = new NumericUpDown();

            using (BindingScope binder = new BindingScope())
            {
                RangedObject source = binder.CreateSource(obj);
                NumericUpDown target = binder.CreateTarget(numericUpDown);

                // ValidWithin on the source object is null
                binder.Bind(source.ValidWithin.Min).To(target.Minimum);
                binder.Bind(source.ValidWithin.Max).To(target.Maximum);
            }

            Assert.AreEqual("ValidWithin.Min", numericUpDown.DataBindings["Minimum"].BindingMemberInfo.BindingMember);
            Assert.AreEqual("ValidWithin", numericUpDown.DataBindings["Minimum"].BindingMemberInfo.BindingPath);
            Assert.AreEqual("Min", numericUpDown.DataBindings["Minimum"].BindingMemberInfo.BindingField);

            Assert.AreEqual("ValidWithin.Max", numericUpDown.DataBindings["Maximum"].BindingMemberInfo.BindingMember);
            Assert.AreEqual("ValidWithin", numericUpDown.DataBindings["Maximum"].BindingMemberInfo.BindingPath);
            Assert.AreEqual("Max", numericUpDown.DataBindings["Maximum"].BindingMemberInfo.BindingField);
        }

        [Test]
        public void TestNavigationPathBindingToPropertyOnPropertyOnSourceWithNullObjectOnEnd()
        {
            SizeContainer obj = new SizeContainer();
            NumericUpDown numericUpDown = new NumericUpDown();

            using (BindingScope binder = new BindingScope())
            {
                SizeContainer source = binder.CreateSource(obj);
                NumericUpDown target = binder.CreateTarget(numericUpDown);

                // Size on the source object is null
                binder.Bind(source.Size).To(target.MinimumSize);
            }

            Assert.AreEqual("Size", numericUpDown.DataBindings["MinimumSize"].BindingMemberInfo.BindingMember);
            Assert.AreEqual("", numericUpDown.DataBindings["MinimumSize"].BindingMemberInfo.BindingPath);
            Assert.AreEqual("Size", numericUpDown.DataBindings["MinimumSize"].BindingMemberInfo.BindingField);
        }
    }
}
