using NUnit.Framework;
using Moq;


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
            var mock = new Mock<Bike>();
            _station.Dock(mock.Object);
            var stationSize = _station.bikes.Count;
            Assert.AreEqual(1, stationSize);
            Assert.True(_station.bikes.Contains(mock.Object));
        }

        [Test]
        public void CanReleaseABike()
        {
            var mock = new Mock<Bike>();
            _station.Dock(mock.Object);
            _station.Release(mock.Object);
            var stationSize = _station.bikes.Count;
            Assert.AreEqual(0, stationSize);
            Assert.False(_station.bikes.Contains(mock.Object));
        }
    }
}