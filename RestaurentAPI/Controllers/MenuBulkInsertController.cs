using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RestaurentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuBulkInsertController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public MenuBulkInsertController(ILogger<MenuController> logger, IRepositoryWrapper repository)
        {
            _repository = repository;
        }
        [HttpPost(Name = "UploadMenu")]
        public void UploadMenu([FromBody] List<Menu> menuItems)
        {
            _repository.MenuRepo.BulkInsertMenu(menuItems);
            
        }

        [HttpDelete]
        public void DeleteMenus([FromBody] List<Menu> menuItems)
        {
            _repository.MenuRepo.DeleteRange(menuItems);
            _repository.Save();
        }
    }
}
