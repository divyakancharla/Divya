using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
   abstract class catergory
    {
        int cid;
        string cname;
        string cdetails;
        public catergory(int cid, string cname, string cdetails)
        {
            this.cid = cid;
            this.cname = cname;
            this.cdetails = cdetails;
        }

        public int Cid { get => cid; set => cid = value; }
        public string Cname { get => cname; set => cname = value; }
        public string Cdetails { get => cdetails; set => cdetails = value; }
        //public override string ToString()
        //{
        //    return this.cid + "" + this.cname + "" + this.cdetails;
        //}
    }

}
    