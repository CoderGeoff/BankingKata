using BankingKata;
using NUnit.Framework;

namespace BankingKataTests
{
    public class DummyTestFixture
    {
        [Test]
        public void DummyTest()
        {
            var dummy = new DummyClass();
            var result = dummy.IsDummy();
            Assert.That(result, Is.True);
        }
    }
}
