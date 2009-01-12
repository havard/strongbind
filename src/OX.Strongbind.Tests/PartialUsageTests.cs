namespace OX.Strongbind.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PartialUsageTests
    {
        [Test]
        public void TestUsingOnlySources()
        {
            IBusinessObject obj = new BusinessObject();
            BindingPairHolder bindingPairHolder = new BindingPairHolder();

            using (BindingScope scope = new BindingScope(bindingPairHolder))
            {
                IBusinessObject source = scope.CreateSource(obj);

                Assert.IsNull(bindingPairHolder.ConsumeBindingPair());

                string name = source.Name;

                BindingPair pair = bindingPairHolder.ConsumeBindingPair();
                Assert.IsNotNull(pair);
                Assert.AreEqual(obj, pair.Object);
                Assert.AreEqual("Name", pair.Member);

                short number = source.ShortValue;

                BindingPair anotherPair = bindingPairHolder.ConsumeBindingPair();
                Assert.IsNotNull(anotherPair);
                Assert.AreEqual(obj, anotherPair.Object);
                Assert.AreEqual("ShortValue", anotherPair.Member);
            }
        }

        // TODO: Test navigation path binding under partial usage
    }
}
