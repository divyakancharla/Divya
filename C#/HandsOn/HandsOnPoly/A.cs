using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPoly
{
   public abstract class A
    {
        //public virtual void display()
        //{
        //    Console.WriteLine("dipslay A class details");
        //}
        public abstract  void display();
    }
    class B:A
    {
        public override void display()
        {
            Console.WriteLine("dipslay B class details");
        }
    }
    class C:A
    {
        public override void display()
        {
            Console.WriteLine("dipslay c class details");
        }
    }
}
