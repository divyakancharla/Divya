using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEX
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            
            
           
            while (true){
                Console.WriteLine("---Menu---");
                Console.WriteLine("1.Insert Emploee Details");
                Console.WriteLine("2.Display all Employee Details:");
                Console.WriteLine("3.Update Employee details");
                Console.WriteLine("Delete A Specific EMployee");
                int n = int.Parse(Console.ReadLine());
                switch (n) {
                    case 1: 
                        
                            int EmpId = int.Parse(Console.ReadLine());
                            string Name = Console.ReadLine(); ;
                            string desc = Console.ReadLine();
                            li.Add(new Employee(EmpId, Name, desc));
                        
                            break;

                                 

                    case 2:
                        foreach (Employee e in li)
                         {
                            Console.WriteLine(e.ToString());
                             }
                        break;



                    case 3:
                // List<int> lii = new List<int>();
                         int id = int.Parse(Console.ReadLine());
                //  lii.Add(id);
                             foreach (Employee i in li)
                                 {
                                 

                                    {
                                     string Names = Console.ReadLine(); 
                                     string descc = Console.ReadLine();
                                // li.Add(new Employee(id, Names, descc));
                                    i.Name1 = Names;
                                    i.Desc = descc;
                                      }


                                         }
                                 foreach (Employee e in li)
                                     {
                                      Console.WriteLine(e.ToString());
                                      }
                                     break;

                    case 4:
                         int id1 = int.Parse(Console.ReadLine());
                         foreach (Employee i in li)
                             {c
                            Employee d = li.Find(c => c.EmpId1 == id1);
                                {
                                Console.WriteLine(li.Remove(i));
                                    }

                              }break;
            
                }
        }
        }
    }
}
