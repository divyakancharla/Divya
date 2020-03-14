using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car C = new Car();
          //  string[] arr = new string[] { "divya", "kalyani" };
           // C.name =arr;
            C[0] = "dadafd";
            C[1] = "dadafd";
            C[2] = "dadafd";
            C[3] = "dadafd";
          //  C[4] = "dadafd";
            C.display();
            Console.WriteLine(C[0]);
        }
    }
}
