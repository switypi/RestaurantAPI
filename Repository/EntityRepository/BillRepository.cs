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
    public class BillRepository : RepositoryBase<Bill>, IBillRepository
    {
        public BillRepository(RestaurentDbContext repositoryContext)
: base(repositoryContext)
        {
        }
    }
}
