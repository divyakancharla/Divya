using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The World Of C#");

            // Gre();
            // ThirdOne();
            // int i = int.Parse(Console.ReadLine());
            // Fourth(i);
            // Fifth();
            //Sixth();
            // Series();
            //fact();
            //fib();
            //mul();
            // Divisible();
            //largest();
            // len();
            // reverse();
            //Compare();
            pal();
            Console.ReadKey();
        }
        public static void Gre()
        {
            string s=Console.ReadLine();
            Console.WriteLine("Hi!"+" "+s);
            Console.WriteLine("Welcome to the world of C#");
          
        }
        public static void ThirdOne()

        {
            int i =int.Parse(Console.ReadLine());
            int j= int.Parse(Console.ReadLine());
            for(int k=i;k<=j;k++)
            {
                Console.WriteLine(k);
               // Console.ReadKey();
                
            }
        }
        public static void Fourth(int k)
        {
            if(k%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        public static void Fifth()
        {
            int even=0, odd=0;
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
               arr[i]= int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    even = even + 1;
                }
                else
                {
                    odd = odd + 1;
                }
            }
            Console.WriteLine("Number Of Even Number:",even);
            Console.WriteLine(odd);
        }
        public static void Sixth()
        {
            int i = int.Parse(Console.ReadLine());
            int f = (i * 9 / 5) + 32;
            Console.WriteLine(f);
        }
        public static void Series()
        {
            for(int i=0;i<=25;i++)
            {
                Console.WriteLine(i * i);

            }
        }
        public static void fact()
        {
            int fact = 1;
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of number:",fact);
        }
        public static void fib()
        {
            int a = 0, b = 1, temp;
            for(int i = 0; i < 40; i++)
            {
                Console.WriteLine(a);
                temp = a + b;
                a = b;
                b = temp;
            }
        }
        public static void mul()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <=20; i++)
            {
                Console.WriteLine(n+"*"+i+"="+n * i);
            }
        }
        public static void Divisible()
        {
            for(int i=200;i<=300;i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void largest()
        {
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if(i>j && i>k)
            {
                Console.WriteLine(i);
            }
            else if(j>k)
            {
                Console.WriteLine(j);
            }
            else
            {
                Console.WriteLine(k);
            }
        }
        public static void len()
        {
            string i = Console.ReadLine();
            
            Console.WriteLine(i.Length);
        }
        public static void reverse()
        {
            int  j;
            String s = Console.ReadLine();
            j = s.Length - 1;
            string rev = " ";
            for(;j>=0;j--)
            {
                rev = rev + s[j];
               
            }

            Console.WriteLine(rev);

        }
        public static void Compare()
        {
            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();
            int i = s1.Length;
            int j = s2.Length;
            if (s1.Length == s2.Length)
            {
                for (int k = 0; k<= i; k++)
                {
                    for (int l = 0; l<=j; l++)
                    {
                      
                            while(s1[k] == s2[l])
                            {
                            if(k == '\0' && l == '\0')
                            {
                                Console.WriteLine("same");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("different");
                            }
                            }
                    }
                }
            }
            else
            {
                Console.WriteLine("No valid to compare");
            }
        }
        public static void pal()
        {
            string s, revs = "";
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            int h = s.Length;
            int i = h - 1;


            while (i >= 0)     //String Reverse  
            {
                revs = revs + s[i].ToString();
                i--;
            }
            if (s == revs) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            Console.ReadKey();
        }

    }





    }

    



