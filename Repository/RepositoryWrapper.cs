
using Infrastructure;
using Repository.EntityRepository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private RestaurentDbContext _repoContext;
        private IUserRepository userRepository;
        private ICustomerRepository customerRepository;
        private ITableRepository tableRepository;
        private IBookingRepository bookingRepository;
        private IWaiterRepository waiterRepository;
        private IOrderRepository orderRepository;
        private IMenuRepository menuRepository;


        public RepositoryWrapper(RestaurentDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }

        public IMenuRepository MenuRepo
        {
            get
            {
                if (menuRepository == null)
                {
                    menuRepository = new MenuRepository(_repoContext);
                }
                return menuRepository;
            }
        }

        public ICustomerRepository CustomerRepo
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new CustomerRepository(_repoContext);
                }
                return customerRepository;
            }
        }
        public IUserRepository UserRepo
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(_repoContext);
                }
                return userRepository;
            }
        }

        public IBookingRepository BookingRepo {
            get
            {
                if (bookingRepository == null)
                {
                    bookingRepository = new BookingRepository(_repoContext);
                }
                return bookingRepository;
            }
        }
        public ITableRepository TableRepo {

            get
            {
                if (tableRepository == null)
                {
                    tableRepository = new TableRepository(_repoContext);
                }
                return tableRepository;
            }
        }

        public IWaiterRepository WaiterRepo
        {
            get
            {
                if (waiterRepository == null)
                {
                    waiterRepository = new WaiterRepository(_repoContext);
                }
                return waiterRepository;
            }
        }

         
       public  IOrderRepository OrderRepo {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new OrderRepository(_repoContext);
                }
                return orderRepository;
            }
        }
    }
}
