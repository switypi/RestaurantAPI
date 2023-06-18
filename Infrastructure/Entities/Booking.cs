using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("Booking")]
    public partial class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BookingId { get; set; }
        public string TableNum { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public long? CustId { get; set; }
        public int? TableId { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Table TableNumNavigation { get; set; }
    }
}
