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


        [HttpGet("GetBookingAsync/{id}")]
        public async Task<BookingDTO> GetBookingAsync(int id)
        {
            var result = await _service.GetBookingAsync(id);
            return result;
        }


        [HttpGet("GetAllBooking/{buildingId}")]
        public IEnumerable<BookingDTO> GetAllBooking(int buildingId)
        {
            return _service.GetAllBooking(buildingId);
        }

        [HttpGet("GetAllBookingsInEndTimeAsync/{endTime}")]
        public async Task<IEnumerable<BookingDTO>> GetAllBookingsInEndTimeAsync(DateTime endTime)
        {
            var result = await _service.GetAllBookingsInEndTimeAsync(endTime);
            return result;
        }

        [HttpGet("GetAllBookingsInCanceledAsync/{canceledTime}")]
        public Task<IEnumerable<BookingDTO>> GetAllBookingsInCanceledAsync(DateTime canceledTime)
        {
            return _service.GetAllBookingsInCanceledAsync(canceledTime);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BookingDTO value)
        {
            await _service.AddBookingAsync(value);
            return Ok();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBookingAsync(BookingDTO bookingDTO)
        {
            await _service.UpdateBookingAsync(bookingDTO);
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBookingAsync(BookingDTO bookingDTO)
        {
            await _service.RemoveBookingAsync(bookingDTO);
            return Ok();
        }
    }
}
