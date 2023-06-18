using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace RestaurentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public BookingController(ILogger<BookingController> logger, IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet(Name = "GetBookings")]
        public IEnumerable<Booking> Bookings()
        {
            return _repository.BookingRepo.FindAll();
        }

        [HttpPost(Name = "AddBooking")]
        public void AddBooking([FromBody] Booking booking)
        {
            _repository.BookingRepo.Create(booking);
            _repository.Save();
        }
    }
}
