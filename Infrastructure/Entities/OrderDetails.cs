using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("OrderDetails")]
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderDetailId { get; set; }
        public int MenuId { get; set; }
        public long OrderId { get; set; }
        public int quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
        public  virtual Order CurrentOrder { get; set; }
        
    }
}
