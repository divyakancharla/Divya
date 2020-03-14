using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HandsOnExampleListDel
{
   class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no of count");
            int n = int.Parse(Console.ReadLine());
            List<Trainee> tlist = new List<Trainee>();
            for(int i=0;i< n;i++)
            {
                int a = int.Parse(Console.ReadLine());
                string b = Console.ReadLine();
                int c = int.Parse(Console.ReadLine());
                tlist.Add(new Trainee(a, b, c));
            }
            List<Trainee> sn = tlist.FindAll(y =>y.Pid!=-1);
            foreach (Trainee r in sn)
            {
                Console.WriteLine(r.ToString());
            }
        }
    }
}
