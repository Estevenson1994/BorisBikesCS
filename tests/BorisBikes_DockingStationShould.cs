using NUnit.Framework;

namespace BorisBikes.UnitTests
{
    public class Tests
    {
        private DockingStation _station;

        [SetUp]
        public void BeforeEachTest()
        {
            _station = new DockingStation();
        }

        [Test]
        public void DockingStationIsInitiallyEmpty()
        {
            var stationSize = _station.bikes.Count;
            Assert.AreEqual(0, stationSize);
        }
    }
}