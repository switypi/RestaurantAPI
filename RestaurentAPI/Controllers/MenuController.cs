using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RestaurentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public MenuController(ILogger<MenuController> logger, IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet(Name = "GetMenuItems")]
        public IEnumerable<Menu> MenuItems()
        {
            return _repository.MenuRepo.FindAll();
        }

        [HttpPost(Name = "AddMenuItem")]
        public void AddMenuItem([FromBody] Menu menuItem)
        {
            _repository.MenuRepo.Create(menuItem);
            _repository.Save();
        }
        [HttpDelete]
       
        public void DeleteMenu([FromBody] Menu menuItem)
        {
            _repository.MenuRepo.Delete(menuItem);
            _repository.Save();
        }

        [HttpDelete]
        [Route("[action]")]
        public void DeleteMenuWithId(int Id) {
            var menuItem=_repository.MenuRepo.FindByCondition(x=>x.MenuId== Id).FirstOrDefault();
            if(menuItem!=null)
            {
                _repository.MenuRepo.Delete(menuItem);
                _repository.Save();
            }
        }
    }
}
