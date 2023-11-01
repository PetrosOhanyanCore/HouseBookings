using BusinessLayer.IService;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace HouseBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentImageController : ControllerBase
    {
        IApartmentImageService _service;

        public ApartmentImageController(IApartmentImageService service)
        {
            _service = service;
        }



        // GET: api/<ApartmentImageController>
        [HttpGet("GetAllApartmentImages")]
        public IActionResult GetAllApartmentImages()
        {
            var images =_service.GetAllApartmentImages();

            if(images == null)
                return NotFound();

            return Ok(images);
        }

        // GET api/<ApartmentImageController>/5
        [HttpGet("GetAllApartmentImagesByApartmentIdAsync")]
        public async Task<IActionResult> GetAllApartmentImagesByApartmentIdAsync(int apartmentId)
        {
           var images = await _service.GetAllApartmentImagesByApartmentIdAsync(apartmentId);

            if (images == null)
                return NotFound();

            return Ok(images);
        }

        // POST api/<ApartmentImageController>
        [HttpPost("AddApartmentImage")]
        public IActionResult AddApartmentImage([FromBody] ApartmentImageDTO value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _service.AddApartmentImage(value);

            return Ok("Image added successfully");
        }

        // PUT api/<ApartmentImageController>/5
        [HttpPut("UpdateApartmentImage")]
        public IActionResult UpdateApartmentImage([FromBody] ApartmentImageDTO value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _service.UpdateImage(value);

            return Ok("pdated successfully");
        }

        // DELETE api/<ApartmentImageController>/5
        [HttpDelete("RemoveApartmentImage")]
        public IActionResult RemoveApartmentImage(ApartmentImageDTO apartmentImageDTO)
        {
            try
            {
                _service.RemoveApartmentImage(apartmentImageDTO);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }



        [HttpDelete("RemoveApartmentImageById")]
        public IActionResult RemoveApartmentImageById(int apartmentId)
        {
            try
            {
                _service.RemoveApartmentImageById(apartmentId);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
