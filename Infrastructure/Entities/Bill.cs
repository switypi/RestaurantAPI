using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("Bill")]
    public partial class Bill
    {
        public Bill()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BillId { get; set; }
        public long? OrderId { get; set; }
        public double TotalAmount { get; set; }
        public double TaxAmount { get;set; }
        public double DiscountAmount { get; set; }
        public double BaseLineTotal { get; set; } 
        public string BillNumber { get; set; }  

        public  Order Orders { get; set; }
        
    }
}
