using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeCasting
{
    class ConvertPractice
    {
        static void Main()
        {
            string s=Convert.ToString(true);
            string s1, s2;
            s1 = Convert.ToString("A");
            s2 = Convert.ToString("1.32");
            Console.WriteLine("{0},{1},{2}",s,s1,s2);
            Console.ReadLine();
        }
    }
}
