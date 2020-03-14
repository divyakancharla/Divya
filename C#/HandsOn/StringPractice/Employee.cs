using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Employee
    {
        string name;
        string empid;
        int salary;
        public Employee()
        {

        }
        public  Employee(string name,string empid,int salary)
        {
            this.name = name;
            this.empid = empid;
            this.salary = salary;
        }
        public override string ToString()
        {
            return this.name + this.empid + this.salary;
        }
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.empid == temp.empid && this.name == temp.name && this.salary == temp.salary)
                return true;
            else
                return false;
        }
    }
}
