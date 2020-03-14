using System;
using System.Collections.Generic;

namespace OrdersService.Models
{
    public partial class Buyer
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Mobilenumber { get; set; }
        public DateTime? Createdatetime { get; set; }
    }
}
