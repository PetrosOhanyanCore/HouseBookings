using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Model.DTO;

namespace BusinessLayer.IService
{
    public interface IBuildingImageService
    {

        Task<BuildingImageDTO> GetBuildingImageByIdAsync(int id);
        Task<ICollection<BuildingImageDTO>> GetBuildingAllImagesAsync(int buildingId);

        BuildingImageDTO GetBuildingImageById(int id);
        IEnumerable<BuildingImageDTO> Find(Expression<Func<BuildingImage, bool>> predicate);
        void AddBuildingImage(BuildingImageDTO buildingImageDTO);
        void AddRangeBuildingImages(ICollection<BuildingImageDTO> buildingImageDTOs);
        void UpdateBuildingImage(BuildingImageDTO buildingImageDTO);
        void UpdateRangeBuildingImages(ICollection<BuildingImageDTO> buildingImageDTOs);
        void RemoveRangeBuildingImages(ICollection<BuildingImageDTO> buildingImageDTOs);
        void RemoveBuildingImage(BuildingImageDTO buildingImageDTO);
    }
}
