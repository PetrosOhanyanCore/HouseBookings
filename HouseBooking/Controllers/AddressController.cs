using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Model.DTO;
using Model.RequestModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HouseBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("GetBuildingByAddressIdAsync/{id}")]
        public async Task<IActionResult> GetBuildingByAddressIdAsync(int id)
        {
            try
            {
                var address = await _addressService.GetBuildingByAddressIdAsync(id);
                return Ok(address);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return NotFound(id);
            }

        }

        [HttpGet("GetBuildingByAddressId/{id}")]
        public async Task<AddressDTO> GetBuildingByAddressId(int id)
        {
            var address = _addressService.GetBuildingByAddressId(id);
            return address;
        }

        [HttpGet("GetBuildingsByCountryAsync/{country}")]
        public async Task<IEnumerable<AddressDTO>> GetBuildingsByCountryAsync(string country)
        {
            var result = await _addressService.GetBuildingsByCountryAsync(country);
            return result;
        }

        [HttpGet("GetBuildingsByCityAsync/{city}")]
        public async Task<IEnumerable<AddressDTO>> GetBuildingsByCityAsync(string city)
        {
            var result = await _addressService.GetBuildingsByCityAsync(city);
            return result;
        }

        [HttpGet("GetBuildingsByDistrictAsync/{district}")]
        public async Task<IEnumerable<AddressDTO>> GetBuildingsByDistrictAsync(string district)
        {
            var result = await _addressService.GetBuildingsByDistrictAsync(district);
            return result;
        }

        [HttpGet("GetBuildingsByHouseTypeAsync/{house, country}")]
        public async Task<IEnumerable<AddressDTO>> GetBuildingsByHouseTypeAsync(string? house, string country)
        {
            var result = await _addressService.GetBuildingsByHouseTypeAsync(house, country);
            return result;
        }

        [HttpGet("GetBuildingsCountByCityAsync/{city}")]
        public async Task<int> GetBuildingsCountByCityAsync(string city)
        {
            var result = await _addressService.GetBuildingsCountByCityAsync(city);
            return result;
        }

        [HttpPost("/Address/Add")]
        public async Task<IActionResult> Add([FromBody] AddressVM address)
        {
            await _addressService.AddAddress(address);
            return Ok();
        }


        [HttpPut("UpdateAddressAsync/{address}")]
        public async Task<IActionResult> UpdateBookingAsync([FromBody] AddressVM address)
        {
            await _addressService.UpdateAddress(address);
            return Ok();
        }

        [HttpDelete("DeleteAddressAsync/{id}")]
        public async Task<IActionResult> RemoveBookingAsync(int id)
        {
            await _addressService.RemoveAddress(id);
            return Ok();
        }
    }
}
