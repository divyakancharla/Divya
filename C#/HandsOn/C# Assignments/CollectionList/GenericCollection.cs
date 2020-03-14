using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionList
{
    class GenericCollection
    {
        static void main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(10);
            li.Add('e');
            Console.WriteLine(li[2]);

        }
    }
}
