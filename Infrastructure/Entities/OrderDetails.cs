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
        public int? MenuId { get; set; }
        public long? OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
      
        public string ServingType { get; set; }
        public decimal? Amount { get; set; }
        public  Order CurrentOrder { get; set; }

    }
}
