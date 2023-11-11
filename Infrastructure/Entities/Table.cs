using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("Table")]
    public partial class Table
    {
        public Table()
        {
            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TableId { get; set; }
        public string TableNumber { get; set; }
        public string Tag { get; set; }
        public string TableType { get; set; }

        //public virtual Order Orders { get; set; }
    }
}
