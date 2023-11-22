using BusinessLayer.IService;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace HouseBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentService _apartmentService;
        public ApartmentController(IApartmentService service)
        {
            _apartmentService = service;
        }


        [HttpPost("AddApartment")]
        public IActionResult AddApartment([FromBody] ApartmentDTO apartment)
        {
            try
            {
                if(apartment == null)
                    return BadRequest("Invalid data.");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _apartmentService.AddApartment(apartment);
                return Ok("Apartment created successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
 
        }

        [HttpPut("UpdateApartment")]
        public IActionResult UpdateApartment([FromBody] ApartmentDTO apartment)
        {
            try
            {
                if (apartment == null)
                    return BadRequest("Invalid data.");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _apartmentService.UpdateApartment(apartment);
                return Ok("Apartment updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteApartment")]
        public IActionResult DeleteApartment([FromBody] ApartmentDTO apartment)
        {
            try
            {
                if (apartment == null)
                    return BadRequest("Invalid data.");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _apartmentService.DeleteApartment(apartment);
                return Ok("Apartment deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("GetApartmentByIdAsync/{Id}")]
        public async Task<ActionResult<ApartmentDTO>> GetApartmentByIdAsync(int id)
        {
            try
            {
                var apartment = await _apartmentService.GetApartmentByIdAsync(id);
                if (apartment == null)
                {
                    return NotFound();
                }

                return apartment;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAllApartments/{BuildingId}")]
        public IActionResult GetAllApartments(int buildingId)
        {
            try
            {
                var apartments = _apartmentService.GetAllApartments(buildingId);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ImagesCountByImageId/{Id}")]
        public IActionResult ImagesCountByImageId(int id)
        {
            try
            {
                var count = _apartmentService.ImagesCountByImageId(id);
                return Ok(count);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetImages/{ApartmentId}/Images/Async")]
        public async Task<IActionResult> GetImagesAsync(int apartmentId)
        {
            try
            {
                var images = await _apartmentService.GetImagesAsync(apartmentId);
                return Ok(images);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAllApartments/Building/{BuildingId}/Async")]
        public async Task<IActionResult> GetAllApartmentsAsync(int buildingId)
        {
            try
            {
                var apartments = await _apartmentService.GetAllApartmentsAsync(buildingId);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Images/Count/{BuildingId}/Async")]
        public async Task<IActionResult> ImagesCountByImageIdAsync(int buildingId)
        {
            try
            {
                var count = await _apartmentService.ImagesCountByImageIdAsync(buildingId);
                return Ok(count);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddApartment/Async")]
        public async Task<IActionResult> AddApartmentAsync([FromBody] ApartmentDTO apartment)
        {
            try
            {
                await _apartmentService.AddApartmentAsync(apartment);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateApartment/async")]
        public async Task<IActionResult> UpdateApartmentAsync([FromBody] ApartmentDTO apartment)
        {
            try
            {
                await _apartmentService.UpdateApartmentAsync(apartment);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("DeleteApartment/Async")]
        public async Task<IActionResult> DeleteApartmentAsync([FromBody] ApartmentDTO apartment)
        {
            try
            {
                if (apartment == null)
                    return BadRequest("Invalid data.");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                await _apartmentService.DeleteApartmentAsync(apartment);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Price-Range/{MinPrice}/{MaxPrice}/Async")]
        public async Task<IActionResult> GetApartmentsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
        {
            try
            {
                if (minPrice > maxPrice)
                    return BadRequest("Invalid price range.");

                var apartments = await _apartmentService.GetApartmentsByPriceRangeAsync(minPrice, maxPrice);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Available/Async")]
        public async Task<IActionResult> GetAvailableApartmentsAsync()
        {
            try
            {
                var apartments = await _apartmentService.GetAvailableApartmentsAsync();
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Rooms-Count/{RoomsCount}/Async")]
        public async Task<IActionResult> GetApartmentsByRoomsCountAsync(int roomsCount)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsByRoomsCountAsync(roomsCount);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Translation/{TranslationId}/Async")]
        public async Task<IActionResult> GetApartmentsByTranslationIdAsync(int translationId)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsByTranslationIdAsync(translationId);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Building/{BuildingId}/Async")]
        public async Task<IActionResult> GetApartmentsByBuildingIdAsync(int buildingId)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsByBuildingIdAsync(buildingId);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Section/{Section}/Async")]
        public async Task<IActionResult> GetApartmentsBySectionAsync(string section)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsBySectionAsync(section);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Number/{Number}/Async")]
        public async Task<IActionResult> GetApartmentsByNumberAsync(string number)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsByNumberAsync(number);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("Floor/{Floor}/Async")]
        public async Task<IActionResult> GetApartmentsByFloorAsync(int floor)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsByFloorAsync(floor);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Floor-Count/{FloorCount}/Async")]
        public async Task<IActionResult> GetApartmentsByFloorCountAsync(int floorCount)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsByFloorCountAsync(floorCount);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Floor-Height/{FloorHeight}/Async")]
        public async Task<IActionResult> GetApartmentsByFloorHeightAsync(double floorHeight)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsByFloorHeightAsync(floorHeight);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Parking-Space/Async")]
        public async Task<IActionResult> GetApartmentsWithParkingSpaceAsync()
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsWithParkingSpaceAsync();
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Penthouse/Async")]
        public async Task<IActionResult> GetPenthouseApartmentsAsync()
        {
            try
            {
                var apartments = await _apartmentService.GetPenthouseApartmentsAsync();
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("Atudio/Async")]
        public async Task<IActionResult> GetStudioApartmentsAsync()
        {
            try
            {
                var apartments = await _apartmentService.GetStudioApartmentsAsync();
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Townhouse/Async")]
        public async Task<IActionResult> GetTownhouseApartmentsAsync()
        {
            try
            {
                var apartments = await _apartmentService.GetTownhouseApartmentsAsync();
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Living-Room-Area/{Area}/Async")]
        public async Task<IActionResult> GetApartmentsByLivingRoomAreaAsync(double area)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsByLivingRoomAreaAsync(area);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Kitchen-Area/{Area}/Async")]
        public async Task<IActionResult> GetApartmentsByKitchenAreaAsync(double area)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsByKitchenAreaAsync(area);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Attached-Kitchen/Async")]
        public async Task<IActionResult> GetApartmentsWithAttachedKitchenAsync()
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsWithAttachedKitchenAsync();
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Balcony-Count/{Count}/Async")]
        public async Task<IActionResult> GetApartmentsByBalconyCountAsync(int count)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsByBalconyCountAsync(count);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Availability/{ApartmentId}/Async")]
        public async Task<IActionResult> IsApartmentAvailableAsync(int apartmentId)
        {
            try
            {
                var isAvailable = await _apartmentService.IsApartmentAvailableAsync(apartmentId);
                return Ok(isAvailable);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Option/{OptionName}/Async")]
        public async Task<IActionResult> GetApartmentsWithOptionAsync(string optionName)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsWithOptionAsync(optionName);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Scoring/{ScoringName}/Async")]
        public async Task<IActionResult> GetApartmentsWithScoringAsync(string scoringName)
        {
            try
            {
                var apartments = await _apartmentService.GetApartmentsWithScoringAsync(scoringName);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Bookings/Count/{ApartmentId}/Async")]
        public async Task<IActionResult> GetTotalBookingsCountAsync(int apartmentId)
        {
            try
            {
                var totalCount = await _apartmentService.GetTotalBookingsCountAsync(apartmentId);
                return Ok(totalCount);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Images/Count/{ApartmentId}/Async")]
        public async Task<IActionResult> GetTotalImagesCountAsync(int apartmentId)
        {
            try
            {
                var totalCount = await _apartmentService.GetTotalImagesCountAsync(apartmentId);
                return Ok(totalCount);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
