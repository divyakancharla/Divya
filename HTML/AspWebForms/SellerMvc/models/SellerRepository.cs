using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerMvc.models
{
    public class SellerRepository:SellerRepositories
    {
      private  List<Seller> lis;
        public SellerRepository()
        {
            lis = new List<Seller>();
            lis.Add(new Seller(1,"deep","div1",2423423,"heelo@kaf.com"));
            lis.Add(new Seller(2, "deep2", "div2", 2423423, "heelo@kaf.com"));
            lis.Add(new Seller(3, "deep3", "div3", 2423423, "heelo@kaf.com"));
        }
        public Seller GetSeller(int id)
        {
            Seller s = lis.FirstOrDefault(e => e.id == id);
            return s;
        }
        public List<Seller> display()
        {
            return lis;
        }
    }
}
