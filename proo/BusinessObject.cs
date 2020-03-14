using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class BusinessObject
    {

    List<buyer> bo = new List<buyer>();
        List<seller> se = new List<seller>();
        //string username;
        //int userid;
        //string fname;
        //string lname;
        //string email;
        //int phn;
        //string rpass;

        //public BusinessObject(string username, string fname, string lname, string email, int phn, string rpass)
        //{
        //    this.fname = fname;
        //    this.lname = lname;
        //    this.username = username;
        //    this.email = email;
        //    this.phn = phn;
        //    this.rpass = rpass;
        //}
        public void reg(string id, string username, string email, int number, DateTime d, string pass)
        {


            // buyer b = new buyer(id, username, email, phn, d, pass);
           
            bo.Add(new buyer(id, username, email, number, d, pass));
            Console.WriteLine("Registered Successfully");

      
        }
        public void regsel(string id, string username, string email, int number, DateTime d, string pass)
        {


            // buyer b = new buyer(id, username, email, phn, d, pass);

            se.Add(new seller(id, username, email, number, d, pass));
            Console.WriteLine("Registered Successfully");
            

        }
        public bool login(string urr,string pass) 
        {
            
            buyer bb = bo.Find(e => e.Username == urr && e.Password == pass);
            if (bb!=null)
            {

                return true;
            }
            else
            {
                return false;
            }
            
    }
        public void display()
        {
            foreach (buyer b in bo)
            {
                Console.WriteLine(b.ToString());
            }
        }

    }
}

