using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryWrapper
    {
        ICustomerRepository CustomerRepo { get; }
        IUserRepository UserRepo { get; }
        IBookingRepository BookingRepo { get;  }
        ITableRepository TableRepo { get; }    
        IWaiterRepository WaiterRepo { get; }
        IMenuRepository MenuRepo { get; }
        IOrderRepository OrderRepo { get; }

        IOrderDetailRepository OrderDetailRepo { get; }

        IBillRepository BillRepo { get; }

        void Save();
    }
}
