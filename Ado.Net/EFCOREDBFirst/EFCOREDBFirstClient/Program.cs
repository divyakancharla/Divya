using System;
using EFCOREDBFirst.Models;
namespace EFCOREDBFirstClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using(PracticeDBContext db=new PracticeDBContext())
            {
                Cours co = new Cours() { Cname = "Java", Cprice = 21000 };
                db.Add(co);
                db.SaveChanges();
            }
        }
    }
}
