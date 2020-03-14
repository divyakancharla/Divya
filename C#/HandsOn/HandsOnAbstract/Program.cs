using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ICIC ic = new ICIC("icici 011","chennai","divya");
            SBI sbi = new SBI("sbi09", "hyd", "kalyani");
            ic.display();
            ic.getinterest();
            sbi.display();
            sbi.getinterest();
            Console.ReadLine();

        }
    }
}
