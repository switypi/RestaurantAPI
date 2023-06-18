using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("Waiter")]
    public partial class Waiter
    {
        public Waiter()
        {
            Tables=new HashSet<Table>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long WaiterId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        
        public DateTime JoinDate { get; set; }
        public int? TableId { get; set; }

        public virtual ICollection<Table> Tables { get; set; }
    }
}
