using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    class vehicle
    {
        public void start()
        {
            Console.WriteLine("Vehicle Startes");
        }
        public void stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }
    }
    class Bus:vehicle
    {
        int seating;
        int speed;
        public void Drive()
        {
            Console.WriteLine("Bus is Running");
        }

    }
    class Car:vehicle
    {
        int seating;
        int speed;
        public void Drive()
        {
            Console.WriteLine("Car is Running");
        }
    }
}
