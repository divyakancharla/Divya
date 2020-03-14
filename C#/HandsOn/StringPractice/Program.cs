using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "Divya";
            //Console.WriteLine(s.Length+ "" + s.Replace("a", "k") + " " + s.ToLower());
            //Console.WriteLine(s.Contains("Div"));
            //Console.WriteLine(string.Compare("hello", "Hello"));
            //string str = "deepu";
            //Console.WriteLine(str.Equals(s, StringComparison.InvariantCulture));
            //string inn = Console.ReadLine();
            //string[] dat = inn.Split(' ', '/');
            //foreach (var a in dat)
            //    Console.WriteLine(a);
            //string dat = Console.ReadLine();
            //   string[] num =dat.Split(' ');
            //   //foreach (var a in num)
            //   //    Console.WriteLine(a);
            //   int[] num2 = Array.ConvertAll(num, Convert.ToInt32);
            //   foreach (var a in num2)
            //       Console.WriteLine(a);
            //int[] num3 = new int[dat.Length];
            //for(int j = 0; j < dat.Length; j++)
            //{
            //    num3[j] = Convert.ToInt32(dat[j]);
            //}
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("dddd/MMMM/yyyy"));
            int[] ix = new int[] { 1, 2, 3, 4 };
            Employee[] earr = new Employee[3] { new Employee("aruna", "100", 2000), new Employee("aruna", "100", 2000), new Employee("aruna", "100", 2000) };
            List<Employee> li = new List<Employee>();
            li.Add(new Employee("deepu", "method", 700));
            Console.WriteLine(li.Count());

            foreach(Employee e in earr)
            {
                Console.WriteLine(e.ToString());
            }
            foreach (Employee e in li)
            {
                Console.WriteLine(e.ToString());
            }
            Employee e1 = new Employee("hammma","100",45);
            Employee e2 = new Employee("hammma", "100", 45);
            if (e1.Equals(e2))
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("Not same");
            }

        }

    }
}
