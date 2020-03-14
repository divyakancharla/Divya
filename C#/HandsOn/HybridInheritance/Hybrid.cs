
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
  abstract  class vehicle
    {
      protected  string color;
        public vehicle()
        {
            this.color = "Audi";
            Console.WriteLine("oneeeeee");
        }
        public vehicle(string clr)
        {
            this.color = clr;
            Console.WriteLine("parametirized");
        }
        public void start()
        {
            Console.WriteLine("Vehicle Startes"+color);
        }
        public void stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }
       public abstract void fillfuel();
    }
    class Bus : vehicle
    {
        int seating;
        int speed;
        public Bus():base("poora"){
            this.seating=4;
            this.speed=160;
            Console.WriteLine("Dhooooo");
         }
     /*   public Bus(string clr) : base(clr)
        {
            Console.WriteLine(clr);
        }*/
        public void Drive()
        {
            Console.WriteLine("Bus is Running");
        }
        public void Run()
        {
            Console.WriteLine(this.speed+this.seating+this.color);
        }
        public override void fillfuel()
        {
            Console.WriteLine("filled fuel");
        }
        public virtual void start()
        {
            Console.WriteLine("nooooo");
        }

    }
    class Car :vehicle
    {
        string color;
        int speed;
        public Car()
        {
            this.color = "white";
            this.speed = 160;
            Console.WriteLine("Theeeen");
        }
    /*    public Car(string clr) : base(clr)
        {
            Console.WriteLine(clr);
        }*/
        public void Drive()
        {
            Console.WriteLine("Car is Running");
        }
        public void Run()
        {
            Console.WriteLine(this.color+this.speed);
        }
        public override void fillfuel()
        {
            Console.WriteLine("filled fuel");
        }
    }
}

