using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EFDAL.Models
{
    [Table("Project")]
  public  class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        [StringLength(30)]
        public string ProjectName { get; set; }
        //set one to many relation with employes
        public IEnumerable<Employe> employes { get; set; }
    }
}                                                                                                      
