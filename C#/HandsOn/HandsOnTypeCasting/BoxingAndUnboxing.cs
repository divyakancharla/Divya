using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeCasting
{
    class BoxingAndUnboxing
    {
       static void Main()
        {
            int i = 23;

            object o = i;
            Object j = "djksdh";
            String s = j.ToString();
            object b = 10;
            int d = (int)b;
            object c = 'A';
            char ch = (char)c;
            object e = 132313;
            double f = (double)e;
            object l = 12.3f;
            float f = (float)l;
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
