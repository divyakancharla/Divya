using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class item
    {

        public int id { get; set; }
        public int cid { get; set; }
        public int sid { get; set; }
        public int price { get; set; }
        public string itemname { get; set; }
        subcatergory sb;

        public item(int id, int cid, int sid, int price, string itemname, subcatergory sb)
        {
            this.id = id;
            this.cid = cid;
            this.sid = sid;
            this.price = price;
            this.itemname = itemname;
            this.sb = sb;

        }
        public override string ToString()
        {
            return this.id + "" + this.price + "" + this.itemname;
        }
    }
}