using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Infrastructure.Entities
{
    [Table("Customer")]
    public partial class Customer
    {
        public Customer()
        {
            Bookings = new HashSet<Booking>();
            HomeDeliveries = new HashSet<HomeDelivery>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CustomerId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Contact { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }


        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<HomeDelivery> HomeDeliveries { get; set; }
    }
}
