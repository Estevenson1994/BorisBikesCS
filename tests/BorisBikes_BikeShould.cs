using NUnit.Framework;
using BorisBikes;

namespace BorisBikes.UnitTests
{
    [TestFixture]
    public class BorisBikes_BikesShould
    {
        private Bike _bike;

        public BorisBikes_BikesShould()
        {
            _bike = new Bike();
        }

        [Test]
        public void ReturnsTrueIfItIsWorking()
        {
            var result = _bike.isWorking;
            Assert.True(result);
        }
    }
}