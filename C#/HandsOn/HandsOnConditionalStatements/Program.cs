using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatements
{
    class Program
    {
        public string even(int i)
        {
            if (i % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "odd";

            }
        }
        public static int Max(int i,int j,int k)
        {
            if(i>j)
            {
                if (i > k)
                {
                    return i;
                }
                else
                {
                    return k;
                }
                
            }
            if (j > k)
            {
                return j;
            }
            else
            {
                return k;
            }
            
        }
        
        public static string Result(double m1, double m2, double m3, double m4, double m5)
        {
            double avg = (m1 + m2 + m3 + m4 + m5) / 5;
            if (avg > 70)
         
                return "distinction";
                    else if (avg > 50 && avg < 60)
                    return "First Class";
                else if (avg < 50 && avg > 40)
                    return "Second Class";
                else
                    return "Fail";
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int i = int.Parse(Console.ReadLine());
            Program p = new Program();
            string s=p.even(i);
            Console.WriteLine(s);
            
            //t j = int.Parse(Console.ReadLine());
            int k = Max(10,12,13);
            Console.WriteLine(k);
            Console.WriteLine(Result(47.5, 33, 76.5, 99, 45));
            //uble m1 = Convert.ToDouble(Console.ReadLine());
            
            Console.ReadKey();


        }
    }
}
