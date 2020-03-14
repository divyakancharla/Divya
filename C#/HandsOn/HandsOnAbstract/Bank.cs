using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstract
{
    interface ILoan
    {
        
        void getinterest();
    }
    interface IGLOan:ILoan
    {
        void getgoldinterest();
    }
    public abstract class Bank
    {
        protected string bname;
        protected string location;
        public Bank(string bname,string location)
        {
            this.bname = bname;
            this.location = location;
        }

    }
    public class SBI : Bank,ILoan
    {
        string bhead;
        public SBI(string bname,string location,string bman):base(bname,location)
        {
            this.bhead = bman;
        }
        public void display()
        {
            Console.WriteLine(this.bname+this.location+this.bhead);
        }
        public void getinterest()
        {
            Console.WriteLine("sbi loan interest rate is 21%");
        }
        
    }
    public class ICIC: Bank,ILoan,IGLOan
    {
        string bhead;
        public ICIC(string bname, string location, string bman) : base(bname, location)
        {
            this.bhead = bman;
        }
        public void display()
        {
            Console.WriteLine(this.bname + this.location + this.bhead);
        }
        public void getinterest()
        {
            Console.WriteLine("icici loan interest rate is 22%");
        }
        public void getgoldinterest()
        {
            Console.WriteLine("icici gold loan interest rate is 12%");
        }
    }
}
