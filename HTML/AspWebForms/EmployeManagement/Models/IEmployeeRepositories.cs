using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeManagement.Models
{
   public interface IEmployeeRepositories
    {
        MyEmployee GetEmployee(int id);
        List<MyEmployee> display();
        bool AddEmployee(MyEmployee me);
    }
}
