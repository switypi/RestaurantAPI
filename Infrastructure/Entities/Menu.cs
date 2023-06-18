using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("Menu")]
    public partial class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MenuId { get; set; }
        public string Name { get; set; }
        public string MenuCode { get; set; }
        public decimal Price { get; set; }
        public string ServingType { get; set; }
        public string? Category { get; set; }
        public bool IsVeg { get; set; } 
        

    }
}
