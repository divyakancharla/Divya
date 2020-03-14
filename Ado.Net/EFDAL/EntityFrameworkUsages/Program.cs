using System;
using EFDAL;
using EFDAL.Context;
using EFDAL.Models;

namespace EntityFrameworkUsages
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext()) {
                Project p = new Project() { ProjectName = "thehey" };
                db.Add(p);
                db.SaveChanges();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
