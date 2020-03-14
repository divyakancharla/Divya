using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstractexmpl
{
    public abstract class Student
    {
        protected string name;
        protected int stuid;
        protected float grade;
        public abstract Boolean Ispassed(float grade);
        public Student()
        {
            this.name = name;
            this.stuid = stuid;
            this.grade = grade;
        }

    }
    class Undergraduate : Student
    {
        public override Boolean Ispassed(float grade)
        {
            if (grade >= 70.0)
            {
                return true;
            }
            else
                return false;
        }

    }
    class graduate : Student
    {
        public override Boolean Ispassed(float grade)
        {
            if (grade >= 80.0)
            {
                return true;
            }
            else
                return false;
        }

    }


}
