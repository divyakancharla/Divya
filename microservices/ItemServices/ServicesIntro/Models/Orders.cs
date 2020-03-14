using System;
using System.Collections.Generic;

namespace ServicesIntro.Models
{
    public partial class Orders
    {
        public string Orderid { get; set; }
        public DateTime? Orderdate { get; set; }
        public string Itemid { get; set; }

        public virtual Items Item { get; set; }
    }
}
