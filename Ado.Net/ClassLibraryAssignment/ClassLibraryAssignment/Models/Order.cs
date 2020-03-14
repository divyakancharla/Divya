using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ClassLibraryAssignment.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [Column(TypeName ="date")]
        public DateTime OrderDate { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime DeliveryDate { get; set; }
        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item item { get; set; }



    }
}
