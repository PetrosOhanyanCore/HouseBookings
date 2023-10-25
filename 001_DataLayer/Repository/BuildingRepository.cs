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
    public class buildingRepository
        : RepositoryBase<Building>,
        IBuildingRepository
    {
        public buildingRepository(DataBaseContext context)
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

        public /*async*/ Task<ICollection<Image<Building>>> GetImages(int buildingId)
        {
            //var images = await _context.Images
            //.Where(p => p.buildindId == BuildingId)
            //.ToListAsync();

            //return images;
            return null;
        }

        public int ImagesCountByImageId(int id)
        {
            //var count = _context.Buildings
            //                .Include(i => i.BuildingImages)
            //                .Where(p => p.BuildingImages
            //                    .Any(s => s.Id == id))
            //                .SelectMany(s => s.BuildingImages)
            //                .Count();
            var count = 0;
            return count;
        }
    }
}