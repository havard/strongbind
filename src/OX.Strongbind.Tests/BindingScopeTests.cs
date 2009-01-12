namespace OX.Strongbind.Tests
{
    using NUnit.Framework;
    using System;
    using System.Runtime.Remoting;
    using System.Windows.Forms;

    [TestFixture]
    public class BindingScopeTests
    {
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestUsingSourceOutsideScopeShouldFail()
        {
            IBusinessObject obj = new BusinessObject();
            
            IBusinessObject source;

            using (BindingScope scope = new BindingScope())
            {
                source = scope.CreateSource(obj);
            }

            string name = source.Name;
        }

        [Test]
        [ExpectedException(typeof(RemotingException))]
        public void TestUsingTargetOutsideScopeShouldFail()
        {
            CheckBox obj = new CheckBox();

            CheckBox target;

            using (BindingScope scope = new BindingScope())
            {
                target = scope.CreateTarget(obj);
            }

            string name = target.Name;
        }
    }
}
