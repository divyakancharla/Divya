using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class ItemBo
    {
        int ch;
        int ch1;
       // seller se = new seller();
        static List<item> llist = new List<item>();
        static List<subcatergory> slist = new List<subcatergory>();
        static List<catergory> ca = new List<catergory>();

        public int Ch { get => ch; set => ch = value; }
        public int Ch1 { get => ch1; set => ch1 = value; }

        public void additem(int cid, string cname, string cdetails, int subid, string subname, string sdetails, int id, int price, string itemname, subcatergory sb)
        {
            subcatergory s = new subcatergory(cid, cname, cdetails, subid, subname, sdetails);
            //catergory c = new catergory(cid, cname, cdetails);
            ca.Add(s);
            slist.Add(s);
            item it = new item(id, cid, subid, price, itemname, s);
            llist.Add(it);
        }
        public void display()
        {
            Console.WriteLine("catergoryid" + " \t " + "Category Name" + "\t  " + "Category Details");
            foreach (catergory c in ca)
            {
                Console.WriteLine(c.Cid + "\t " + c.Cname + "\t " + c.Cdetails);
                // int ch = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Select a Category:");
            Ch = int.Parse(Console.ReadLine());

            foreach (subcatergory sb in slist)
            {
                
                if (sb.Cid==Ch)
                {
                    Console.WriteLine("Subcatergoryid" + " \t  " + "SubCategory Name" + " \t  " + "SubCategory Details");
                    Console.WriteLine(sb.Subid + "\t " + sb.Subname + "\t " + sb.Sdetails);

                }
                else
                {
                    Console.WriteLine("No Sub Categories");
                }
            }
            Console.WriteLine("Enter Sub Categoryn Details:");
            Ch1 = int.Parse(Console.ReadLine());
            foreach (item sb in llist)
            {
               
                if (sb.sid==Ch1)
                {
                    Console.WriteLine("Itemid" + "  " + "Item Name" + " " + "Item Price");
                    Console.WriteLine(sb.id + "\t " + sb.itemname + "\t " + sb.price);
                    break;
                }
                else
                {
                    Console.WriteLine("No Items To SHow");
                }
            }


        }
        public void displaysel()
        {
           // Console.WriteLine("enter Your Id:");
           // int id = int.Parse(Console.ReadLine());

                foreach(item it in llist)
                {
                    
               
                    Console.WriteLine( "Itemid" + "  " + "Item Name" + " " + "Item Price");
                    Console.WriteLine( it.id + "\t " + it.itemname + "\t " + it.price);
                }

                
            
        }
        public void search()
        {
           string search;
            Console.WriteLine("Item To Search");
            search = Console.ReadLine();
            item s = llist.Find(e =>e.itemname == search);
            Console.WriteLine(s.ToString());
            subcatergory su = slist.Find(e => e.Subname == search);
            Console.WriteLine(su.ToString());
            catergory ci = ca.Find(e => e.Cname == search);
            Console.WriteLine(ci.ToString());
        }

    }
}
