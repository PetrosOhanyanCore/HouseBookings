using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Linq.Expressions;
using Model.DTO;

namespace BusinessLayer.IService
{
    public interface IBuildingService
    {
        Task<BuildingDTO> GetBuildingById(int buildingId);
        IEnumerable<BuildingDTO> GetAllBuildings(int locationId);
        int ImagesCountByImageId(int id);
        public void Add(BuildingDTO entity);
        public void AddRange(IEnumerable<BuildingDTO> entities);
   
        public void Remove(BuildingDTO entity);
        public void RemoveRange(IEnumerable<BuildingDTO> entities);
        public void Update(BuildingDTO entity);
        public void UpdateRange(IEnumerable<BuildingDTO> entities);


    }
}
