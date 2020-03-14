using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace ValidationOnMvc.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Username is Required")]
        [DisplayName("username")]
        public string Uname { get; set; }
        [Required(ErrorMessage="Password is Required")]
        [DisplayName("password")]
        public string pwd { get; set; }
    }
}
