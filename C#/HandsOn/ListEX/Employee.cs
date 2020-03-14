using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEX
{
    class Employee
    {
        int EmpId;
        string Name;
        string desc;

        public int EmpId1 { get => EmpId; set => EmpId = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Desc { get => desc; set => desc = value; }

        public   Employee(int EmpId, string Name,string desc)
        {
            this.EmpId1 = EmpId;
            this.Name1 = Name;
            this.Desc = desc;
        }
        public override string ToString()
        {
            return this.EmpId1 + this.Name1 + this.Desc;

        }
      
    }
}
