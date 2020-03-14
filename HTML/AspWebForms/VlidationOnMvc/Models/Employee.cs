using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace ValidationOnMvc.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "pls Enter ID")]
        [DisplayName("Employee Id")]

        public int ID{ get; set; }
        [Required(ErrorMessage = "Pls Enter Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name Should be lenghth 20")]
        public string Name{get;set;}
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage="Invalid Mobole no")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Enter Valid User Name")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Enter valid Password")]
        [RegularExpression(@"[a-z0-9]{6,8}")]
        public string Pwd { get; set; }
        [Compare("Pwd",ErrorMessage ="password Mismatch")]
        public string Cpwd { get; set; }

    }
}
