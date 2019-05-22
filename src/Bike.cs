using System;

namespace BorisBikes
{
    public class Bike
    {
        public bool isWorking;

        public Bike()
        {
            isWorking = true;
        }

        public void Break()
        {
            isWorking = false;
        }


    }
}
