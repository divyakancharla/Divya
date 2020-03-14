using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EFDAL.Models
{
    [Table("Employe")]
  public  class Employe
    {
        [Key]
        [StringLength(5)]
        public string Eid { get; set; }
        [Required]
        [StringLength(30)]
        public string Ename { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "Date")]

        public DateTime? EndDate { get; set; }
        public string Designation { get; set; }
        public decimal? Salary { get; set; }

        public int ProjectId { get; set; }
        //navigation property
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

    }
}
