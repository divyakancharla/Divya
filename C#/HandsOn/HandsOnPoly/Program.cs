using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            /* shape s = new shape();
             s.draw();
             s.draw(2);
             s.draw(2,3);
             s.draw(2,3,4);
             s.draw(4,4,4, "cube");
            */
            //A obj = new A();
            //obj.display();
            //B obj1 = new B();
            //obj1.display();
            //C obj2 = new C();
            //obj2.display();
            //Console.ReadKey();
            //A obj = new A();
            //obj.display();
            A obj;
            obj = new B();
            obj.display();
            obj= new C();
            obj.display();
            Console.ReadKey();
        }
    }
}
