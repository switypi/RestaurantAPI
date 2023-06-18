using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Entities;

namespace Repository.Interfaces
{
    public interface IMenuRepository : IRepositoryBase<Menu>
    {
        void BulkInsertMenu(List<Menu> dt);
    }
}
