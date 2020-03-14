using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    sealed class Singleton
    {
        static int count = 0;
        static Singleton ins=null;
            public static Singleton GeInstance
             {
                get {
                if (ins == null)
                    return new Singleton();
                else

                    return ins;

            }  
        }
         Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
        public void printDetails(string s)
        {
            
            Console.WriteLine("singletonnn"+s);
        }
    }
}
