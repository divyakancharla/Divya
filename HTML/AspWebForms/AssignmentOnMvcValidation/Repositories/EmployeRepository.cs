using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentOnMvcValidation.Models;
namespace AssignmentOnMvcValidation.Repositories
{
    public class EmployeRepository
    {
       // List<Employee> list = new List<Employee>();
        public static List<Employee> list = new List<Employee>()
        {
            new Employee() {Eid=45, Name = "divya", Desg = "Manager" ,ProjName = "Banking", Password = "1234" }
    };
        public EmployeRepository()
        {


        }
        public void register(Employee em)
        {
            list.Add(em);
        }
        public Employee validate(int eid,string password)
        {
            foreach(var emp in list)
            {
                if(emp.Eid==eid && emp.Password == password)
                {
                    return emp;
                }
            }
            return null;
        }
    }
}
