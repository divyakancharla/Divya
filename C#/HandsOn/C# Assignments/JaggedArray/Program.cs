using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDImensionalArray
{
    class JaggedArray
    {
        static void Main(string[] args) {
            string[][] name = new string[3][];
            for(int i = 0; i < 3; i++) { 
            int size = int.Parse(Console.ReadLine());
            name[i]=new string[size];
    }
            for (int row = 0; row < 3; row++) {
                for (int col = 0; col < name[row].Length; col++)
                {
                    name[row][col] = Console.ReadLine();
                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < name[row].Length; col++)
                {
                    Console.WriteLine(name[row][col]);
                }
                Console.WriteLine();
            }
            foreach(string s in name[1])
            {
                Console.WriteLine(s);
            }

        }
    }

}
