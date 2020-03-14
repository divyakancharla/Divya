using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace AssignmentOnMvcValidation.Models
{
    public class Employee
    {
        [RegularExpression("@[0-9]{6}",ErrorMessage ="Enter valid Id:")]

        [DisplayName("Employee ID")]
        public int Eid { get; set; }
        [Required(ErrorMessage ="Enter Valid Name")]
        [DisplayName("Employee Name")]
        public string Name { get; set; }
        [RegularExpression("@[a-z]",ErrorMessage ="Enter VAlid Designation")]
        [DisplayName("Designation")]
        public string Desg { get; set; }
        [RegularExpression("@[a-z]", ErrorMessage = "Enter VAlid Designation")]
        [DisplayName("Project Name:")]
        public string ProjName { get; set; }
        [RegularExpression("@[a-z0-9]{6,9}", ErrorMessage = "Enter VAlid Designation")]
        [DisplayName("Password")]
        public string Password { get; set; }


    }
}
