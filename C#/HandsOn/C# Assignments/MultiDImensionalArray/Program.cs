﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            /*  for (int i = 0; i < 5; i++)
              {
                  for (int j = 0; j < 3; j++)
                  {
                      Console.WriteLine(marks[i, j]+"\t");
                  }
              }*/
            foreach (int x in marks)
            {
                Console.WriteLine(x);
            }
            int topscore = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0) topscore = marks[i, j];
                                                                                                                                             
                    if (marks[i, j] > topscore)
                        topscore = marks[i, j];
                }
                Console.WriteLine("highest is:" + topscore);
            }
           
        }
    }
}
