using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnUserException
{
    class Program
    {
        static void Main(string[] args)
        {
            salException s = new salException("kalyani", 799);
            try
            {
                if (s.salary == 0) throw new Employee("salary cant be 0");
            }
            catch(Employee e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
        }
    }
}
