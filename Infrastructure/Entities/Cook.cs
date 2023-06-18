using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("Cook")]
    public partial class Cook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CookId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        
        public DateTime JoinDate { get; set; }
        public string Specialization { get; set; }
    }
}
