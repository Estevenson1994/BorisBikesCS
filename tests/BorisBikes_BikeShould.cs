using NUnit.Framework;
using BorisBikes;

namespace BorisBikes.UnitTests
{
    [TestFixture]
    public class BorisBikes_BikesShould
    {
        private Bike _bike;

        [SetUp]
        public void BeforeEachTest()
        {
            _bike = new Bike();
        }

        [Test]
        public void ReturnsTrueIfItIsWorking()
        {
            var result = _bike.isWorking;
            Assert.True(result);
        }

        [Test]
        public void ReturnsFalseIfBikeIsBroken()

        {
            _bike.Break();
            var result = _bike.isWorking;
            Assert.False(result);
        }
    }
}