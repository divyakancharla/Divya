using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStatements
{
    class Program
    {
        public static void whole(int i)
        {
            int flag = 0;
            do
            {
                Console.WriteLine(flag + "\t");
                flag++;

            } while (flag <= i);
        }
        public static int fact(int k)
        {
            int factr = 1, i = 1;
            /* for(i=1; i <= k; i++)
               {
                   factr= factr* i;
               }
               return factr;  */
            /*for(;i<= k; i++)
              {
                  factr= factr* i;
              } */
            for (; ; )
            {
                if(i<=k)
                {
                    factr = factr * i;
                    i++;
                }

                else
                {
                    break;
                }
            }
    return  factr;

        }
     /* public static int fa(int k)
        {
            int i;
            for(i=1; i <= k; i++)
               {
                   jf(i%2==1)
                    {
                    continue;
                    Console.WriteLine(i); }
                }
        }*/
        public static void Greet(string i)
        {
            int flag = 1;
            while (flag <= 10)
            {
                Console.WriteLine(i);
                flag++;
            }
        }

        public static string vowel(int ch)
        {
            string result = null;
            switch(ch)
            {
                case 'a':
                    result = "vowel";
                    break;
                case 'e':
                    result = "vowel";
                    break;
                case 'i':
                    result = "vowel";
                    break;
                case 'o':
                    result = "vowel";
                    break;
                case 'u':
                    result = "vowel";
                    break;
                default:
                    result = "invalid";
                    break;
            }
            return result;
        }
        public static void menu(int ch)
        {
            
            switch (ch)
            {      
                case 1:
                    Console.WriteLine("Enter number:");
                 //   int i = int.Parse(Console.ReadLine());
                   
                    eveodd();
                    break;
                case 2:
                    natural();
                    break;
                case 3:
                    Multi();
                    break;
                case 4:
                    break;
              //  default:
                  //  Console.Write("invalid choice");

            }
        }
        public static void eveodd()
        {
            int k = int.Parse(Console.ReadLine());
            if (k % 2 == 0)
            {
                Console.WriteLine("even");

            }
            else
            {
                Console.Write("odd");
            }
        }
        public static void Multi()

        {
            int k = int.Parse(Console.ReadLine());
            for(int i=1;i<k;i++)
            {
                Console.WriteLine(i * k);
            }
        }
        public static void natural()
        {
            int k = int.Parse(Console.ReadLine());
            for (int i=1;i<k;i++)
            {
                Console.WriteLine(i + " ");
            }
        }
         static void Main(string[] args)
            {
            // string i = Console.ReadLine();
            //eet(i);
            //ole(50);
            // Console.WriteLine(fact(4));
            // fa(10);
            //  Console.WriteLine(fact(4));
            //  char j = char.Parse(Console.ReadLine());
            //   Console.WriteLine(vowel(j));
            Console.WriteLine("1.Even/odd");
            Console.WriteLine("2.Natural");
            Console.WriteLine("3.Multipication");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your choice:");
           int i = int.Parse(Console.ReadLine());
           // int j= Console.Read();
            menu(i);

            Console.ReadKey();
        }
    }
}
