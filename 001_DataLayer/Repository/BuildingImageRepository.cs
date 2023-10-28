using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.IRepository;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository
{
    public class BuildingImageRepository : RepositoryBase<BuildingImage> , IBuildingImageRepository
    {
        public BuildingImageRepository(DataBaseContext context) : base(context)
        {
        }


        public async Task<BuildingImage> GetBuildingImageByIdAsync(int id)
        {
            var result = await _context.BuildingImages.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<ICollection<BuildingImage>> GetBuildingAllImagesAsync(int buildingId)
        {
            var images = await _context.BuildingImages
                          .Where(x => x.BuildingId == buildingId)
                          .ToListAsync();

            return images;
        }

 


    }
}
