using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AssignmentOnArray
{
    class JaggedArray
    {
        static void Main(String[] args)
        {
            List<int> li = new List<int>();
            int[][] arr = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                int size = int.Parse(Console.ReadLine());
                arr[i] = new int[size];
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = int.Parse(Console.ReadLine());
                }


            }
            int k = arr[0][0], sum = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j=0; j < arr[i].Length; j++)

                {
                    if (arr[i][j] == arr[i+1][k+1])
                    {
                        sum = sum + arr[i][j];
                    }
                    {

                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
