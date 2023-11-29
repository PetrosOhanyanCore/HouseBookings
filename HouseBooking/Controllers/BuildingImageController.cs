using BusinessLayer.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DTO;

namespace HouseBooking.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BuildingImageController
    {
        public IBuildingImageService _service;

        public BuildingImageController(IBuildingImageService service)
        {
            _service = service;
        }

        [HttpGet("GetBuildingImageByIdAsync/{id}")]
        public async Task<BuildingImageDTO> GetBuildingImageByIdAsync(int id)
        {
            var result = await _service.GetBuildingImageByIdAsync(id);
            return result;
        }

        [HttpGet("GetBuildingAllImagesAsync/{buildingId}")]
        public async Task<ICollection<BuildingImageDTO>> GetBuildingAllImagesAsync(int buildingId)
        {
            return await _service.GetBuildingAllImagesAsync(buildingId);
        }


        [HttpPost("AddBuildingImage/{buildingImageDTO}")]
        //[Authorize(Roles = "Admin, User")]

        public void AddBuildingImage(BuildingImageDTO buildingImageDTO)
        {
            _service.AddBuildingImage(buildingImageDTO);
        }


        [HttpPost("AddRangeBuildingImages/{buildingImageDTOs}")]
        public void AddRangeBuildingImages(ICollection<BuildingImageDTO> buildingImageDTOs)
        {
            _service.AddRangeBuildingImages(buildingImageDTOs);

        }


        [HttpPut("UpdateBuildingImage/{buildingImageDTO}")]
        public void UpdateBuildingImage(BuildingImageDTO buildingImageDTO)
        {
            _service.UpdateBuildingImage(buildingImageDTO);
        }

        [HttpPut("UpdateRangeBuildingImages/{buildingImageDTOs}")]
        public void UpdateRangeBuildingImages(ICollection<BuildingImageDTO> buildingImageDTOs)
        {
            _service.UpdateRangeBuildingImages(buildingImageDTOs);
        }

        [HttpDelete("RemoveBuildingImage/{buildingImageDTO}")]
        public void RemoveBuildingImage(BuildingImageDTO buildingImageDTO)
        {
            _service.RemoveBuildingImage(buildingImageDTO);
        }

        [HttpDelete("RemoveRangeBuildingImages/{buildingImageDTOs}")]
        public void RemoveRangeBuildingImages(ICollection<BuildingImageDTO> buildingImageDTOs)
        {
            _service.RemoveRangeBuildingImages(buildingImageDTOs);
        }
    }
}
