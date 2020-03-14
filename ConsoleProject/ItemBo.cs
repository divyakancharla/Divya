using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class ItemBo
    {
        static List<item> llist = new List<item>();
        static List<subcatergory> slist = new List<subcatergory>();
        static List<catergory> ca = new List<catergory>();
        public void additem(int cid, string cname, string cdetails, int subid, string subname, int id, int price, string itemname, subcatergory sb)
        {
            subcatergory s = new subcatergory(cid, cname, cdetails, subid, subname);
            catergory c = new catergory(cid, cname, cdetails);
            item it = new item(id, cid, subid, price, itemname, s);
            llist.Add(it);
        }
        public void display()
        {
            foreach (catergory c in ca)
            {
                Console.WriteLine(c.ToString());
                // int ch = int.Parse(Console.ReadLine());

            }
            foreach (catergory c in ca)
            {

                int ch = int.Parse(Console.ReadLine());
                if (ch == c.Cid)
                {
                    foreach (subcatergory sb in slist)
                    {
                        Console.WriteLine(sb.Subid + " " + sb.Subname);

                    }
                }


            }
            foreach (subcatergory sc in slist)
            {

                int ch = int.Parse(Console.ReadLine());
                if (ch == sc.Subid)
                {
                    foreach (item sbb in llist)
                    {
                        Console.WriteLine(sbb.id + " " + sbb.price + " " + sbb.itemname);

                    }
                }


            }

        }


        
    }
}
