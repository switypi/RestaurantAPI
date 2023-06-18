using Infrastructure;
using Infrastructure.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EntityRepository
{
    internal class OrderRepository:RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(RestaurentDbContext repositoryContext)
: base(repositoryContext)
        {
        }
    }
}
