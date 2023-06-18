using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Order
    {
        public long OrderId { get; set; }
       
        public int? TableId { get; set; }
        public long? CustomerID { get; set; }   

        public virtual ICollection<OrderDetails>? CurrentOrderDetails { get; set; }
        public Bill CurrentBill { get; set; }
        public Table CurrentTable { get; set; }
        public Customer CurrentCustomer { get; set; }
    }
}
