using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ClassLibraryAssignment.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string Itemname { get; set; }
        [Required]
        public  decimal? Itemprice { get; set; }
        public IEnumerable<Order> orders { get; set; }
       

    }
}
