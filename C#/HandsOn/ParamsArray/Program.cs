using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Calculator
    {
        public void Add(params int[] x)
        {
            int res = 0;
            foreach (int i in x) res += 1;
           // res=x.
            Console.WriteLine(res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add(1,2,3,7);
            Console.WriteLine(c.GetType());
        }
    }

}
