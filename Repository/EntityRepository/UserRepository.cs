
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
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RestaurentDbContext repositoryContext)
    : base(repositoryContext)
        {
        }
    }
}
