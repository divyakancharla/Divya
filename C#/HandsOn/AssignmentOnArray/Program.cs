using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
     
            if (n % 2 == 0)
            {
                Console.WriteLine("enter only odd number");
            }
            else
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                if (arr.Length == 1)
                {
                    Console.WriteLine(arr[0]);
                }
                else
                {
                    int lenn = arr.Length;
                    int start = arr[0];
                    int mid = arr[lenn / 2];
                    int end = arr[lenn - 1];
                    if (start > mid && start > end)
                    {
                        Console.WriteLine("highest is:"+start);
                    }
                    else if (mid > end)
                    {
                        Console.WriteLine("highest is:"+mid);
                    }
                    else
                    {
                        Console.WriteLine("highest is:" +end);
                    }

                }
            }
        }
    }
}
