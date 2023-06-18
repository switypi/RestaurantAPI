using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RestaurentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public OrderController(ILogger<OrderController> logger, IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet(Name = "GetOrdrs")]
        public IEnumerable<Order> Orders()
        {
            return _repository.OrderRepo.FindAll();
        }

        [HttpPost(Name = "AddOrder")]
        public void AddOrder([FromBody] Order order)
        {
            _repository.OrderRepo.Create(order);
            _repository.Save();
        }
    }
}
