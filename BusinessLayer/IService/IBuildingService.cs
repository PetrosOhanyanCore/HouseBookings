using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BusinessLayer.IService
{
    public interface IBuildingService
    {
        Task<BuildingDTO> GetBuildingById(int buildingId);
        IEnumerable<BuildingDTO> GetAllBuildings(int locationId);
        int ImagesCountByImageId(int id);
    }
}
