using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerMvc.models
{
    public class Seller
    {
      public  int id { get; set; }
      public  string name { get; set; }
      public  string pass { get; set; }
      public  int phn{get;set;}
      public  string email { get; set; }
        public Seller(int id,string name,string pass,int phn,string email)
        {
            this.id = id;
            this.name = name;
            this.pass = pass;
            this.phn = phn;
            this.email = email;

        }

    }
}
