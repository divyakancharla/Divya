using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] i=new int[6]{1,2,3,4,5,8};
            int[] j = { 10, 20, 30 };
            //Console.WriteLine(i[2]);
            //for(int k=0;k<3;k++)
           // {
                //Console.WriteLine(i[k]);
           // }
           // foreach(int l in i)
           // {
               
               //  
                //Console.WriteLine(l+2);
                

            //}
            double[] d = new double[4] { 1, 2, 33, 44 };
            object[] pom = new object[] { "fffef", 'f', 44 };
            for(int i = 0; i< 3; i++)
            {
                pom[i] = Console.ReadLine();
            }
            foreach(object o in pom)
            {
                Console.WriteLine(o);
            }
            //Console.ReadKey();

        }
    }
}
