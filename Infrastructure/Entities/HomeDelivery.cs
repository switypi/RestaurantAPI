using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("HomeDelivery")]
    public partial class HomeDelivery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DeliveryId { get; set; }
        public long? CustId { get; set; }
        public long? OrderId { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Order Order { get; set; }
    }
}
