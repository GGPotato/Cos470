using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var x = DollarAddresses.Program.ThingThatShouldBeTested();
            Assert.IsTrue(x == 1);
            Assert.Pass();
        }
    }
}