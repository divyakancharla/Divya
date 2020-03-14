using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVariablesWithDataTypes
{
    class Program
    {
        String name;//instance variable 
        static double ss;
        static void Main(string[] args)
        {
            object b = 1;
            b = "deepu";
            b = 4324234;
            int i=10;//local variable
            int[] a = new int[4] { 1, 2, 3, 4 };
            Console.WriteLine(i);
            Program p = new Program();
           Console.WriteLine(Program.ss);
            Console.WriteLine(p.name);
            Console.WriteLine(b);
            int id = 45;
            String name = "divya";
            Console.WriteLine("name:{0} id:{1}",name,id);
            Console.ReadKey();

        }
    }
}
