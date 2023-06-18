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
    public  class WaiterRepository : RepositoryBase<Waiter>, IWaiterRepository
    {
        public WaiterRepository(RestaurentDbContext repositoryContext)
    : base(repositoryContext)
        {
        }
    }
}
