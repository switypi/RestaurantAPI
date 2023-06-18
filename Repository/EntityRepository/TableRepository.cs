using Infrastructure;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EntityRepository
{
    internal class TableRepository : RepositoryBase<Infrastructure.Entities.Table>, ITableRepository
    {
        public TableRepository(RestaurentDbContext repositoryContext)
    : base(repositoryContext)
        {
        }
    }
}
