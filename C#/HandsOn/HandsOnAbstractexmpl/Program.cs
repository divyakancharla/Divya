using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstractexmpl
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Student s;
            s = new Undergraduate();
            s = new graduate();
            int n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("enter grade");
                float f = float.Parse(Console.ReadLine());
               Console.WriteLine( s.Ispassed(f));
            }
            if (n == 2)
            {
                Console.WriteLine("enter grade");
                float f = float.Parse(Console.ReadLine());
               Console.WriteLine( s.Ispassed(f));
            }
        }
    }
}
