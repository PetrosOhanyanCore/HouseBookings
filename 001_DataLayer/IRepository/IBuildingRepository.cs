using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IBuildingRepository : IRepositoryBase<Building>
    {
        Task<Building> GetBuildingByIdAsync(int id);

        IEnumerable<Building> GetAllBuildings(int locationid);

        int ImagesCountByImageId(int id);

        Task<ICollection<Image<Building>>> GetImages(int buildingid);

    }

}