using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate
{
  //  public delegate void deligatePointer();
    public delegate double calArea(double x);
    public delegate double display(double x);
    class Program
    {

        static void Main(string[] args)
        {
            //    Program P = new Program();
            //    deligatePointer s=P.print;
            //    s += P.display;
            //    s();
            //    calArea cl = Calculate.calArea;
            //    cl -= Calculate.calAreaa;
            //    double d = cl(4);
            //    Console.WriteLine(d);
            //  //  Calculate c=new Calculate(display)
            //}
            //public void print()
            //{
            //    Console.WriteLine("iofjifj");
            //}
          //public static   double  display(double d)
          //  {
          //      Console.WriteLine("iofjifj");
          //  }
          //  calArea c1 = new calArea(display);
            //calArea c = new calArea(delegate(double r)
            //{
            //    return 3 * r;
            //});
            
            //double d = c(34);
            //Console.WriteLine(d);
            //calArea c2 = (r => 3.14 * r * r);

            //double d1= c2(34);
            //Console.WriteLine(d1);
            //prebuild deledates<> func delegates<>Action<>predicate<>
            Func<double, double> f1= (r => 3.14 * r * r);
            double area = f1(3343);
            Console.WriteLine(area);
            // Func<string, int> f2 = (r = int.Parse(s));
            Action<string> act = (x1 => Console.WriteLine(x1));
            act("stranger");
            Predicate<string> pe = (c => c.Length > 4);
            Console.WriteLine(pe("hj"));
            int[] arr = new int[] { 1, 2, 34 };
            List<string> li = new List<string>();
            li.Add("mithravindha");
            li.Add("devasena");
            li.Add("Siva Gami");
            int x = arr.Count(g=> g>4); ;
            Console.WriteLine(x);
           List<string>sn= li.FindAll(y => y.Contains('a'));
            foreach(string n in sn)
            {
                Console.WriteLine(n);
            }
        }
    }
}
