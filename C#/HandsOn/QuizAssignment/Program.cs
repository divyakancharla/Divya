

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are You Ready For The Quiz? Y/N");
            char n = char.Parse(Console.ReadLine());
            if (n== 'Y')
            {
                for(int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Q1.What Is The Capital Of India?","\n","1.Delhi","\n","2.Mumbai","\n","3.Chennai);

                }
            }
        }
    }
}
