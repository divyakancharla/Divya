using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeCasting
{
    class Parse
    {
        static void Main()
        {
            /*String i = "100";
            int n = int.Parse(i);
            float f = float.Parse(i);
            double d = double.Parse(i);*/
            sbyte n = sbyte.Parse("100");
           
            bool d = bool.Parse("true");
            Console.WriteLine("{0},{1},{2}", n, d);
            Console.ReadLine();
        }
    }

}
