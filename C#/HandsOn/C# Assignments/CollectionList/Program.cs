using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList a = new ArrayList();
             a.Add("divya");
             a.Add(2.44);
             a.Add('a');
             a.Add(true);
             a.Add(3234234234);
             var i = 12;
             i = 89;
             Console.WriteLine(i);
             dynamic d;
             d = 23;
             d = 23.4;
             foreach (var s1 in a)
             {
                 Console.WriteLine(s1);
             }
             Queue q = new Queue();
             q.Enqueue(12);
             q.Enqueue(false);
             q.Enqueue("divya");
             q.Dequeue();

             foreach(var s2 in q)
             {
                 Console.WriteLine(s2);
             }
             Stack s = new Stack();
             s.Push(23);
             s.Push("divya");
             s.Push(23.12);
             Console.WriteLine(s.Pop());
             Console.WriteLine(s.Peek());
             Hashtable ht = new Hashtable();
             ht.Add('a', 131);
             ht.Add('b',231);
             ht.Add('d', 432343);
             foreach(var h in ht.Keys)
             {
                 Console.WriteLine(ht[h]);

             }

             // Console.WriteLine(ht[1]);
           List<int> li = new List<int>();
             li.Add(10);
             li.Add(10);
             li.Add('e');
             Console.WriteLine(li[2]);
             Queue<string> q = new Queue<string>();
             q.Enqueue("fsd");
             q.Enqueue("1");
             Console.WriteLine(q.Dequeue());
             Stack<float> st = new Stack<float>();
             st.Push(21);
             st.Push(21.2f);
             foreach (var v in st)
                 Console.WriteLine(v);
             HashSet<int> hs = new HashSet<int>();
             hs.Add(10);
             hs.Add(10);
             foreach (dynamic d in hs)
                 Console.WriteLine(d);*/
            Dictionary<string, int> dt = new Dictionary<string, int>();
            int count;
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
              //String n2 = Console.ReadLine();
              //int k = int.Parse(Console.ReadLine());
              //dt.Add(n2, k);
              dt.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
            }
            int hsal = 0;
            string hname = "";
            foreach(KeyValuePair<string,int> emp in dt){
                if (emp.Value > hsal)
                {
                    hsal = emp.Value;
                    hname = emp.Key;
                }
            }
            Console.WriteLine(hname);

        }
    }
}
