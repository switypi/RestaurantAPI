using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
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
        [EnableQuery]
        public IEnumerable<Order> Orders()
        {
            return _repository.OrderRepo.FindAll();
        }

        [HttpPost(Name = "AddOrder")]
        public async void AddOrder([FromBody] Order order)
        {
            using (var trans = _repository.OrderRepo.GetDbContext.Database.BeginTransaction())
            {
                try
                {
                    Order newOrder = new Order { CustomerID = order.CustomerID, OrderType = order.OrderType, TableId = order.TableId, TableNumber = order.TableNumber, OrderDate = order.OrderDate };
                    foreach (var item in order.CurrentOrderDetails)
                    {
                        newOrder.CurrentOrderDetails.Add(new OrderDetails { Amount = item.Amount, MenuId = item.MenuId, Quantity = item.Quantity, ServingType = item.ServingType, UnitPrice = item.UnitPrice });

                    }

                    _repository.OrderRepo.Create(newOrder);

                    _repository.Save();
                    trans.Commit();
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    throw e;
                }


            }

        }

        [HttpDelete("Delete")]
        public async void Delete(int id)
        {
            using (var trans = _repository.OrderRepo.GetDbContext.Database.BeginTransaction())
            {
                try
                {
                    var orderObj = _repository.OrderRepo.FindByCondition(x => x.OrderId == id).FirstOrDefault();
                    if (orderObj != null)
                    {
                        var objOrderdtl = _repository.OrderDetailRepo.FindByCondition(x => x.OrderId == orderObj.OrderId).FirstOrDefault();
                        if (objOrderdtl != null)
                        {
                            _repository.OrderDetailRepo.Delete(objOrderdtl);
                        }

                        _repository.OrderRepo.Delete(orderObj);
                    }
                    _repository.Save();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
               
            }
        }
    }
}
