using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOStudent
{
    public abstract class student
    {
        protected int studid;
        protected string name;
        protected double examfee;
        public student(int studid, string name,double examfee)
        {
            this.studid = studid;
            this.name = name;
            this.examfee = examfee;
        }
        public abstract void displayDetails();
       
        public abstract double payFee(double d);
        
    }
    class DayScholar : student
    {
       // double transfee;
        public DayScholar(int studid, string name, double examfee):base(studid,name,examfee)
        {
            //this.transfee = transfee;
        }
        public override void displayDetails()
        {
            Console.WriteLine(this.studid + this.name + this.examfee
                );
        }
        public override double payFee(double transfee)
        {
            return transfee+examfee;
        }
    }
    class Hosteller : student
    {
      //  double hostfee;
        public Hosteller(int studid, string name, double examfee) : base(studid,name,examfee)
        {
            //this.hostfee = hostfee;
        }
        public override void displayDetails()
        {
            Console.WriteLine(this.studid+ this.name + this.examfee );
        }
        public override double payFee(double hostfee)
        {
            return hostfee+examfee;
        }
    }
}
