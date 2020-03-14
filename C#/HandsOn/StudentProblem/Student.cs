using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProblem
{
    class Student
    {
       static string Colgnam;
        int rol;
        string name;
        string cls;
        int sem;
        string branch;
       int[] arr = new int[5];
        public Student(string Colgnam,
        int rol,
        string name,
        string cls,
        int sem,string branch,int[] arr)
        {
           // this.Colgnam = Colgnam;
            this.rol = rol;
            this.name = name;
            this.cls = cls;
            this.sem = sem;
            this.branch = branch;
            this.arr = arr;
        }
        public static void st()
        {
            Colgnam = "Sir C R R";
        }
        public void display(int[] marks)
        {
            int flag=0;
            int sum = 0, avg = 0;
            for(int i = 0; i < 5; i++)
            {
                sum = sum + marks[i];
                avg = sum / 5;
            }
            for (int i = 0; i < 5; i++)
            {
                
                
                if (marks[i] <= 35 && avg<50)
                {
                    flag = 0;
                }
                else if(avg>50)
                {
                    flag = 1;
                }
               
            }
            if (flag == 1)
            {
                Console.WriteLine("PASSED");
            }
            else
            {
                Console.WriteLine("Failed");
            }


            Console.WriteLine(Colgnam + "\t" + rol + "\t" + name + "\t" + cls + "\t" + sem + "\t" + branch);
        }
    }
}
