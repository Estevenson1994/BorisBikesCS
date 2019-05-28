using System;
using System.Collections.Generic;

namespace BorisBikes
{
    public class DockingStation
    {
        public List<Bike> bikes;

        public DockingStation()
        {
            bikes = new List<Bike>();
        }

        public void Dock(Bike bike)
        {
            bikes.Add(bike);
        }

        public void Release(Bike bike)
        {
            bikes.Remove(bike);
        }

    }
}
