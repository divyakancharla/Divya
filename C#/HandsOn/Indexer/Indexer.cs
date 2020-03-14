using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Car
    {
        int year;
        string[] name = new string[4];
        public int Year
        {
            get { return Year; }
            set { Year = value; }
        }

    //    public string[] Name { get => name; set => name = value; }
        public string this[int x]
        {
            get
            {
                return name[x];
            }
            set
            {
                name[x] = value;
            }
        }
        public void display()
        {
            foreach(var x in this.name)
            {
                Console.WriteLine(x);
            }
        }
    }
}
