using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Search
    {
        public static void Main()
        {
            
            int flag = 0;         
            string s1 = Console.ReadLine();

            string[] s = new string[3]
            { "divya", "lalli", "rahul" };
            foreach (string n in s)
            {
                if(n==s1)
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("not exists");
            }
            else
            {
                Console.WriteLine("exists");
            }
                
                    
                
            


        }

    }
}
