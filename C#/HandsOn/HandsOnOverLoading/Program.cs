using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            delivery d = new delivery();
            Console.WriteLine("menu");
            Console.WriteLine("1.player details of delivery");
            Console.WriteLine("2.run details of the delivery");
            Console.WriteLine("enter choice");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("player details of delivery");
                    d.DisplayDeliveryDetails("kalyani", "divya");
                    break;
                case 2:
                    Console.WriteLine("run details of the delivery");
                    Console.WriteLine("enter num");
                    int n = int.Parse(Console.ReadLine());
                    d.DisplayDeliveryDetails(n);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
            Console.ReadLine();
        }
    }
}
