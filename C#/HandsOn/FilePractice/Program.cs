using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilePractice
{
    class Program
    {
        static void Main(string[] args)
        {
          //  DirectoryInfo di = new DirectoryInfo(@"E:\deepu\pooora\Pusukk");
          //  if(di.Exists==false)
          //  di.Create();
          ////di.CreateSubdirectory("fasakk");
          //  DirectoryInfo[] d = di.GetDirectories();
          //  foreach(DirectoryInfo x in d)
          //  {
          //      Console.WriteLine(x.Name + x.FullName + x.CreationTime);
          //  }
          //  FileInfo[] ds = di.GetFiles();
          //  Console.WriteLine("-------------");
          //  Console.WriteLine(ds.Length);
          //  foreach (FileInfo x in ds)
          //  {
          //      Console.WriteLine(x.Name + x.FullName + x.CreationTime);
          //  }
          //  FileStream fs = new FileStream(@"E:\deepu\pooora\Hello.txt",
          //      FileMode.OpenOrCreate,FileAccess.Write);
          //  StreamWriter s = new StreamWriter(fs);
          //  s.WriteLine("welcome");
          //  for(int i = 0; i < 2; i++)
          //  {
          //      string ss = Console.ReadLine();
          //      s.WriteLine(ss);
          //  }
            FileStream fs1 = new FileStream(@"E:\deepu\pooora\Hello.txt",
                FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader s1 = new StreamReader(fs1);
            string st;
            while((st=s1.ReadLine())!=null)
            {
                Console.WriteLine(st);
            }
            FileStream fs2 = new FileStream(@"E:\deepu\pooora\Helloo.txt",
                FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter br = new BinaryWriter(fs2);
            int i = 20;
            string s = "cola";
            char ch = 'h';
            br.Write(i);
            br.Write(s);
            br.Write(ch);
            s1.Close();
            fs1.Close();
            br.Close();
            fs2.Close();
            FileStream fs3 = new FileStream(@"E:\deepu\pooora\Helloo.txt",
                FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader brr = new BinaryReader(fs3);
            int i1 = brr.ReadInt32();
            string ss = brr.ReadString();
            char chh = brr.ReadChar();


            Console.WriteLine(i1 +"\n" +ss+"\n" + chh);
            brr.Close();
            fs3.Close();
        }
    }
}
