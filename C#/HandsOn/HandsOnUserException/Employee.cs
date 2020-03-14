using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnUserException
{
    public class Employee:Exception
    {
        public Employee(string s):base(s)
        {

        }
    }
    public class salException
    {
        public string name;
        public int salary;
        public salException(string name,int salary)
        {
            this.name = name;
            this.salary = salary;

        }
    }

}
