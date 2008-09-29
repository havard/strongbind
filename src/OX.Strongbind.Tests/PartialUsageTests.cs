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
            using (BindingScope scope = new BindingScope())
            {
                IBusinessObject source = scope.CreateSource(obj);

                Assert.IsNull(BindingPairHolder.ConsumeBindingPair());

                string name = source.Name;

                BindingPair pair = BindingPairHolder.ConsumeBindingPair();
                Assert.IsNotNull(pair);
                Assert.AreEqual(obj, pair.Object);
                Assert.AreEqual("Name", pair.Member);

                short number = source.ShortValue;

                BindingPair anotherPair = BindingPairHolder.ConsumeBindingPair();
                Assert.IsNotNull(anotherPair);
                Assert.AreEqual(obj, anotherPair.Object);
                Assert.AreEqual("ShortValue", anotherPair.Member);
            }
        }
    }
}
