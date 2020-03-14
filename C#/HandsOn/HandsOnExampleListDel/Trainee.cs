using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExampleListDel
{
    class Trainee
    {
        int tid;
        string tname;
        int pid;
        public Trainee(int tid,string tname,int pid)
        {
            this.tid = tid;
            this.tname = tname;
            this.pid = pid;
        }

        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }
        public int Pid { get => pid; set => pid = value; }
        public override string ToString()
        {
            return this.tname;
        }
    }
}
