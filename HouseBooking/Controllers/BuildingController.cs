using BusinessLayer.IService;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace HouseBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
       private readonly IBuildingService _service;

        public BuildingController(IBuildingService service)
        {
            _service = service;
        }


        [HttpGet("GetAllBuildings/{locationid}")]
        public IEnumerable<BuildingDTO> GetAllBuildings(int locationId)
        {
            return _service.GetAllBuildings(locationId);
        }

        [HttpGet("GetBuildingById/{locationid}")]
        public async Task<BuildingDTO> GetBuildingById(int buildingId)
        {
            return await _service.GetBuildingById(buildingId);
        }

        [HttpPost("AddBuilding")]
        public void Add(BuildingDTO buildingdto)
        {
            _service.Add(buildingdto);
        }

        [HttpPost("AddRangeBuilding")]
        public void AddRange(IEnumerable<BuildingDTO> buildingdto)
        {
            _service.AddRange(buildingdto);
        }

        [AllowAnonymous]
        [HttpDelete("deleteBuilding/{id}")]
        public void Delete(BuildingDTO buildingdto)
        {
            _service.Remove(buildingdto);
        }

        [HttpDelete("deleteBuildings/{id}")]
        public void DeleteBuildings(IEnumerable<BuildingDTO> buildingdto)
        {
            _service.RemoveRange(buildingdto);
        }


    }
}
