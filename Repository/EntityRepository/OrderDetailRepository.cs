using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Infrastructure.Entities;
using Repository.Interfaces;

namespace Repository.EntityRepository
{
    public class OrderDetailRepository : RepositoryBase<OrderDetails>, IOrderDetailRepository
    {
        public OrderDetailRepository(RestaurentDbContext repositoryContext)
: base(repositoryContext)
        {
        }
    }
}
