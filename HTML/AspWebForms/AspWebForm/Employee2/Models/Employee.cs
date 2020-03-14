using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee2.Models
{
    public enum Dept
    {
        IT, Accounts, Insurance, HealthCare
    }
    public class Employee
    {
        //[Required(ErrorMessage = "Required")]
        // [MaxLength(10)]
        public int Id { get; set; }
        //[Required(ErrorMessage = "Required")]
        //[RegularExpression(@"[a-zA-Z]{5,8}", ErrorMessage = "Enter VAlid NAme")]
        public string Name { get; set; }
        //[EmailAddress(ErrorMessage = "Enter Valid Email")]
        //[ValidateDomain(allowDomain: "CTS.com")]
        //[Remote(action: "IsEmailExist", controller: "Employee")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "field Required")]
        // [RegularExpression("@[a-z]",ErrorMessage ="Enter VALid dept")]
        public Dept dept { get; set; }
        //   public string Dept { get => this.dept; set => this.dept = value; }

        public Employee(int id, string name, string email, Dept dept)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.dept = dept;
        }
        public Employee()
        {

        }
    }
}
