
using System;
using System.Collections.Generic;
using System.Text;

namespace OopsEx
{
    class Student
    {
        int rollno;
        private string name;
        int sem;
        string branch;
        int marks;
        public Student()
        {
            this.rollno=23;
            this.Name="divya";
            this.marks=2;
            DisplayStudentDetails();
            Console.WriteLine("jkshfj");

        }
        public Student(string name,int rollno,string branch,int sem,int marks)
        {
            
            this.name = name;
            this.rollno = rollno;
            this.branch = branch;
            this.sem = sem;
            this.marks = marks;
        }
        public int ROllNo {
            get
            {
                return rollno;
            }
            set
            {
                rollno = value;
            }
        
        }
        public int Sem
        {
            set
            {
                Sem = value;
            }
        }

        public string Name { get; set; }
        public int Marks
        {
            get; set;
        }

        public void AcceptStudentDetails()
        {
            rollno = int.Parse(Console.ReadLine());
           this.Name =(Console.ReadLine());
            sem = int.Parse(Console.ReadLine());
            branch =(Console.ReadLine());
            marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Student Details are accepted");

        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine(rollno);
            
            //Console.WriteLine(sem);
            //
            Console.WriteLine(branch);
            Console.WriteLine(marks);
            Console.WriteLine("Student Details Are Displayed");

        }

        
    }
}
