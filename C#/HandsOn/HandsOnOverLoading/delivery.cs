using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOverLoading
{
    class delivery
    {
        public void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine(bowler);
            Console.WriteLine(batsman);
        }
        public void DisplayDeliveryDetails(long runs)
        {
            if (runs == 6)
            {
                Console.WriteLine("six");
            }
            else if (runs == 4)
            {
                Console.WriteLine("four");
            }
            else
                Console.WriteLine(runs);
        }
    }
}
