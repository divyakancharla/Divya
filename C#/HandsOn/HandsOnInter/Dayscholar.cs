using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInter
{
    interface studentId
    {
         //string name;
         //int stuid;

        string name { get; set; }
        int stuid { get; set; }

        void showdetails();
        
    }
    class Dayscholar:studentId
    {
        public string name;
       public int stuid;
        string studentId.name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
           
        }
        int studentId.stuid
        {
            get
            {
                return stuid;
            }
            set
            {
                stuid = value;
            }
        }
        public void showdetails()
        {
            Console.WriteLine(this.name + " " + this.stuid);
        }
    }
    class resident : studentId
    {
        public string name;
        public int stuid;
        string studentId.name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        int studentId.stuid
        {
            get
            {
                return stuid;
            }
            set
            {
                stuid = value;
            }
        }

        public virtual void showdetails()
        {
            Console.WriteLine(this.name + " " + this.stuid);
        }
    }
}
