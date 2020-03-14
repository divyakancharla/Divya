using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class subcatergory:catergory
    {
        int subid;
        string subname;
        int cid;
        string cname;
        string sdetails;
        public subcatergory(int cid, string cname,string cdetails,int subid,string subname,string sdetails):base( cid,cname,cdetails)
        {
            this.cid = cid;
            this.cname = cname;
            this.Cdetails = Cdetails;
            this.subid = subid;
            this.subname = subname;
            this.sdetails = sdetails;
        }

        public int Subid { get => subid; set => subid = value; }
        public string Subname { get => subname; set => subname = value; }
        public string Sdetails { get => sdetails; set => sdetails = value; }

        public override string ToString()
        {
            return this.Subid + "" + this.subname + "" + this.sdetails;
        }
    }
}
