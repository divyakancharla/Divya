using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeManagement.Models
{
    public class EmployeeRepositories:IEmployeeRepositories
    {
        List<MyEmployee> empList;
        public EmployeeRepositories()
        {
            empList = new List<MyEmployee>{new MyEmployee(1,"Ajay","poola@gmail.com",Dept.IT),new MyEmployee(2, "Vijay", "poola@gmail.com",Dept.Insurance), new MyEmployee(2, "Vijay", "poola@gmail.com", Dept.HealthCare) };

        }
        public MyEmployee GetEmployee(int id)
        {
            MyEmployee e = empList.FirstOrDefault(e => e.Id == id);
            return e;
            //foreach(MyEmployee ee in empList)
            //{
            //    if (e.Id == id)
            //    {
            //        Console.WriteLine(e.Name + e.Email + e.Dept);
            //    }
            //}
        }
        public List<MyEmployee> display()
        {
            return empList;
        }
        public bool AddEmployee(MyEmployee e)
        {
            e.Id = empList.Max(e=> e.Id + 1);
            empList.Add(e);
            return true;
        }
    }
}
