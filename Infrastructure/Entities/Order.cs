using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Order
    {
        public Order()
        {
            this.CurrentOrderDetails=new List<OrderDetails>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderId { get; set; }
        public string OrderType { get; set; }
        public int? TableId { get; set; }
        public DateTime OrderDate { get; set; }
        public string TableNumber { get; set; }
        public long? CustomerID { get; set; }
        public bool IsBilled { get; set; }

        public ICollection<OrderDetails>? CurrentOrderDetails { get; set; }
        public ICollection<Bill>? CurrentBills { get; set; }
        public Table? CurrentTable { get; set; }
        public Customer? CurrentCustomer { get; set; }
    }
}
