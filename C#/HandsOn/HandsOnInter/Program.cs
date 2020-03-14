using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dayscholar d = new Dayscholar();
            resident r = new resident();
            Console.WriteLine("enter");
            int a = int.Parse(Console.ReadLine());
              if(a==1)
            {
               
                Console.WriteLine("enter name");
                d.name = Console.ReadLine();
                Console.WriteLine("number");
                d.stuid = int.Parse(Console.ReadLine());
                d.showdetails();
            }
            else if(a==2)
            {
                Console.WriteLine("enter name");
                r.name = Console.ReadLine();
                Console.WriteLine("number");
                r.stuid = int.Parse(Console.ReadLine());
                r.showdetails();
            }
            
            
        }
    }
}
