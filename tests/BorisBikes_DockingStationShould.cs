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

        [Test]
        public void CanDockABike()
        {
            Bike bike = new Bike();
            _station.Dock(bike);
            var stationSize = _station.bikes.Count;
            Assert.AreEqual(1, stationSize);
        }
    }
}