using System;
using System.Collections.Generic;

namespace WebApiMissingOne.Models
{
    public partial class Test
    {
        public string Pid { get; set; }
        public string Pname { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Edate { get; set; }
    }
}
