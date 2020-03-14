using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerMvc.models
{
   public interface SellerRepositories
    {
        Seller GetSeller(int id);
       public List<Seller> display();
    }
}
