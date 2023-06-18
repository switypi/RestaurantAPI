using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("Cashier")]
    public partial class Cashier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CashierId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public byte[] Bdate { get; set; }
        public byte[] JoinDate { get; set; }
    }
}
