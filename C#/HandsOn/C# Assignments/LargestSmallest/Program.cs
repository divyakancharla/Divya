using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int max = a[0];
            int min;
            min = a[0];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j<a.Length; j++)
            {

                if (a[j] > max)

                    max = a[j];


            }
            for (int j = 0; j < a.Length; j++)
            {


                if (a[j] < min)

                    min = a[j];


            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
        
    }
}
