using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RestaurentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public TableController(ILogger<TableController> logger, IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet(Name = "GetTables")]
        public IEnumerable<Table> Tables()
        {
            return _repository.TableRepo.FindAll();
        }

        [HttpPost(Name = "AddTable")]
        public void AddTable([FromBody] Table table)
        {
            _repository.TableRepo.Create(table);
            _repository.Save();
        }
    }
}
