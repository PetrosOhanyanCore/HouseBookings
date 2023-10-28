using DataLayer.IRepository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class BuildingRepository
        : RepositoryBase<Building>,
        IBuildingRepository
    {
        public BuildingRepository(DataBaseContext context)
            : base(context)
        {
        }

        public IEnumerable<Building> GetAllBuildings(int LocationId)
        {
            List<Building> models = _context.Buildings
            .Where(p => p.LocationId == LocationId)
            .ToList();

            return models;
        }

        public async Task<Building> GetBuildingByIdAsync(int id)
        {
            var result = await _context.Buildings.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }

        public async Task<ICollection<BuildingImage>> GetImages(int buildingId)
        {
            var images = await _context.BuildingImages
                                      .Where(x => x.BuildingId == buildingId)
                                      .ToListAsync();

            return images;
        }


        public int ImagesCountByBuildingId(int buildingId)
        {
            var count = _context.BuildingImages
                              .Count(x => x.BuildingId == buildingId);

            return count;
        }
    }
}