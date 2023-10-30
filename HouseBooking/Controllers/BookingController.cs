using BusinessLayer.IService;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HouseBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        IBookingService _service;

        public BookingController(IBookingService service)
        {
            _service = service;
        }


        [HttpGet("{id}")]
        public Task<BookingDTO> GetBookingAsync(int id)
        {
            return _service.GetBookingAsync(id);
        }


        [HttpGet("{buildingId}")]
        public IEnumerable<BookingDTO> GetAllBooking(int buildingId)
        {
            return _service.GetAllBooking(buildingId);
        }

        [HttpGet("{endTime}")]
        public Task<IEnumerable<BookingDTO>> GetAllBookingsInEndTimeAsync(DateTime endTime)
        {
            return _service.GetAllBookingsInEndTimeAsync(endTime);
        }

        [HttpGet("{canceledTime}")]
        public Task<IEnumerable<BookingDTO>> GetAllBookingsInCanceledAsync(DateTime canceledTime)
        {
            return _service.GetAllBookingsInCanceledAsync(canceledTime);
        }

        [HttpPost]
        public OkResult Post([FromBody] BookingDTO value)
        {
            _service.AddBookingAsync(value);
            return Ok();
        }


        [HttpPut("{id}")]
        public OkResult UpdateBookingAsync(BookingDTO bookingDTO)
        {
            _service.UpdateBookingAsync(bookingDTO);
            return Ok();
        }


        [HttpDelete("{id}")]
        public OkResult RemoveBookingAsync(BookingDTO bookingDTO)
        {
            _service.RemoveBookingAsync(bookingDTO);
            return Ok();
        }
    }
}
