using System;
using System.Collections.Generic;
using System.Linq;
using EntityFrameworkCoreIntro.Models;
namespace EntityFrameworkCoreIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                Student s = new Student() { Sname = "Junnu", Age = 110, Std = "II" };
                db.Add(s);
                db.SaveChanges();
                Student s1 = db.Students.Find(1);
                if (s != null)
                {
                    Console.WriteLine("Welcome {0}", s.Sname);
                }
                else
                {
                    Console.WriteLine("no Data To show");
                }

                //*****Fetching Record******
                Student ss = db.Students.SingleOrDefault(i => i.Sname == "Junnu");//single primary KEy
                List<Student> list = db.Students.Where(i => i.Age == 10).ToList(); //list of data
                List<Student> list1 = db.Students.Where(i => i.Age == 10 && i.Std=="II").ToList();//multiple conditions

                //----Update Record---
                Student s2 = db.Students.Find(1);
                s2.Age = 45;
                db.Students.Update(s2);
                db.SaveChanges();

                //<_>Remove<_>
                List<Student> ls = db.Students.Where(i => i.Sname == "Junnu").ToList();
                foreach (var stu in ls)
                {
                    db.Students.Remove(stu);
                    db.SaveChanges();
                }

            }
            //Console.WriteLine("Hello World!");
        }
    }
}
