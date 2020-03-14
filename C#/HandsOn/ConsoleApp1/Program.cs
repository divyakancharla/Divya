using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns

{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmploye = Singleton.GeInstance; ;
            fromEmploye.printDetails("welcome");
            Singleton fromStudent=Singleton.GeInstance;
        }
    }
}
