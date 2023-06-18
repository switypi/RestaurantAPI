using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RestaurentAPI.Controllers
{

    [ApiController]
    [Route("Api/Customer")]
    public class CustomerController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public CustomerController(ILogger<WeatherForecastController> logger, IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet(Name = "GetCusomers")]
        public IEnumerable<Customer> Customers()
        {
            return _repository.CustomerRepo.FindAll();
        }

        [HttpPost(Name ="AddCustomer")]
        public void AddCustomer([FromBody] Customer customer)
        {
            _repository.CustomerRepo.Create(customer);
            _repository.Save();
        }


    }
}
