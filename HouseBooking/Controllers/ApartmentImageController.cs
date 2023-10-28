using BusinessLayer.IService;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ApartmentImageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApartmentImageController>
        [HttpPost]
        public void Post([FromBody] ApartmentImageDTO value)
        {
            _service.AddApartmentImage(value);
        }

        // PUT api/<ApartmentImageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApartmentImageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
