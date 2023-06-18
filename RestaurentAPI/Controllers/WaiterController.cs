using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RestaurentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaiterController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public WaiterController(ILogger<WaiterController> logger, IRepositoryWrapper repository)
        {
            _repository = repository;
        }
        [HttpGet(Name = "GetWaiters")]
        public IEnumerable<Waiter> Waiters()
        {
            return _repository.WaiterRepo.FindAll();
        }

        [HttpPost(Name = "AddWaiter")]
        public void AddWaiter([FromBody] Waiter waiter)
        {
            _repository.WaiterRepo.Create(waiter);
            _repository.Save();
        }
    }
}
