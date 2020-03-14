using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    class Hybrid
    {
        public static void Main(string[] args)
        {
          //  vehicle v = new vehicle("white");
            Bus b = new Bus();
            Car c = new Car();
          //  v.start();
          //  v.stop();
            
            b.start();
            b.stop();
            b.Drive();
            b.Run();
            b.fillfuel();
            c.start();
            c.stop();
            c.Drive();
            c.Run();
            c.fillfuel();

        }
    }
}