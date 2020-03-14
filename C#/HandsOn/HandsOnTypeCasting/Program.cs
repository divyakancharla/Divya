using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            long l1 = 500000;
            int l2 = (int)l1;
            Console.WriteLine(l2);
            //Console.ReadLine();
            float l3 = 5.1f;
            int l4 = (int)l3;
            int l5 = (int)l3 + l4;
            Console.WriteLine(l5);
            int b =259;
            byte b1 = (byte)b;
            Console.WriteLine(b1);
            Console.ReadLine();
            int i = int.Parse("22");
          
        }
    }
}
