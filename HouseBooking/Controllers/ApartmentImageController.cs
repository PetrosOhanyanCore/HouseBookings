using BusinessLayer.IService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Model;
using Microsoft.AspNetCore.Authorization;

namespace HouseBooking.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/[controller]")]
    public class ApartmentImageController : ControllerBase
    {
        IApartmentImageService _service;

        public ApartmentImageController(IApartmentImageService service)
        {
            _service = service;
        }

        // POST api/<ApartmentImageController>
        [HttpPost("AddApartmentImage")]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public IActionResult AddApartmentImage([FromBody] ApartmentImageDTO value)
        {
            try
            {
                if (value == null)
                    return BadRequest("Invalid data.");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _service.AddApartmentImage(value);
                return Ok("Apartment created successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/<ApartmentImageController>
        [HttpGet("GetAllApartmentImages")]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public IActionResult GetAllApartmentImages()
        {
            var images = _service.GetAllApartmentImages();

            if (images == null)
                return NotFound();

            return Ok(images);
        }

        // GET api/<ApartmentImageController>/5
        [HttpGet("GetAllApartmentImagesByApartmentIdAsync")]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> GetAllApartmentImagesByApartmentIdAsync(int apartmentId)
        {
            var images = await _service.GetAllApartmentImagesByApartmentIdAsync(apartmentId);

            if (images == null)
                return NotFound();

            return Ok(images);
        }

        // PUT api/<ApartmentImageController>/5
        [HttpPut("UpdateApartmentImage")]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
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
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
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
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserManagerResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
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
