using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace mvcExample.Models
{
    public class User
    {
        [RegularExpression("@[a-z]", ErrorMessage = "Enter VAlid Name")]
        [DisplayName("Name")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Enter VAlid Name")]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Range(09-08-2000,25-01-2020)]
        [Required(ErrorMessage = "Enter VAlid Designation")]
        [DisplayName("Date Of Birth")]
        public DateTime DOB { get; set; }
        [RegularExpression("@[6,9]{9}", ErrorMessage = "Enter VAlid Number")]
        [DisplayName("Mobile Number")]
        public int Mobileno { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage = "Select Coutry")]
        [DisplayName("Country")]
        public string Country { get; set; }
        [RegularExpression("@[a-z]", ErrorMessage = "Enter Valid Username")]
        [DisplayName("UserName")]
        public string Uname { get; set; }
        [RegularExpression("@[a-z0-9]{6,9}", ErrorMessage = "Enter VAlid Password")]
        [DisplayName("Password")]
        public string Pwd { get; set; }
    }
}
