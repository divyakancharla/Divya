using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class item
    {
      public  int id { get; set; }
      public  int cid { get; set; }
      public  int sid { get; set; }
      public  int price { get; set; }
      public  string itemname { get; set; }
        public int Seid { get => seid; set => seid = value; }

        subcatergory sb;
        int seid;
        public item(int id, int cid, int sid, int price, string itemname, subcatergory sb)
        {
            this.id = id;
            this.cid = cid;
            this.sid = sid;
            this.price = price;
            this.itemname = itemname;
            this.sb = sb;
            this.Seid = seid;

        }
        public override string ToString()
        {
            return this.id + "" + this.price + "" + this.itemname;
        }
    }
}
