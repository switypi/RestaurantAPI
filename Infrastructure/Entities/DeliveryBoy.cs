using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("DeliveryBoy")]
    public partial class DeliveryBoy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DeliveryBoyId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        
        public DateTime JoinDate { get; set; }
    }
}
