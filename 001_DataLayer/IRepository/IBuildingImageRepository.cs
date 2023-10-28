using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataLayer.IRepository
{
    public interface IBuildingImageRepository : IRepositoryBase<BuildingImage>
    {
        Task<BuildingImage> GetBuildingImageByIdAsync(int id);

        Task<ICollection<BuildingImage>> GetBuildingAllImagesAsync(int buildingId);
    }
}
