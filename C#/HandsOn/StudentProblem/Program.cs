using System;

namespace StudentProblem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] ar = new int[5];
            string Colgnam = Console.ReadLine();
            int rol = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string cls = Console.ReadLine();
            int sem = int.Parse(Console.ReadLine());
            string branch = Console.ReadLine();
            Student s = new Student(Colgnam,rol,name, cls,sem,branch,ar);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter marks:");
                ar[i] = int.Parse(Console.ReadLine());
            }
            s.display(ar);
           /* Student s1=new Student(Colgnam;
            int rol,
            string name;
            string cls;
            int sem;
            string branch;);*/
        }
    }
}
