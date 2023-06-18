using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("SaleDetail")]
    public partial class SaleDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public byte[] Date { get; set; }
        public long Daily { get; set; }
        public long? Weekly { get; set; }
        public long? Monthly { get; set; }
        public string Rname { get; set; }
    }
}
