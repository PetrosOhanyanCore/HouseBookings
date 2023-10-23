using DataLayer;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class ImageRepository :
        RepositoryBase<Image>,
        IImageRepository
    {
        public ImageRepository(DataBaseContext context)
            : base(context)
        {
        }

        public IEnumerable<Image> GetAllImages(int buildingId)
        {
            var result = _context.Images.Where(p => p.BuildingId == buildingId);
            return result;
        }

        public async Task<Image> GetImageByIdAsync(int id)
        {
            var image = await _context.Images.FirstOrDefaultAsync(c => c.Id == id);
            return image;
        }

        public Image GetImageByID(int id)
        {
            var image = _context.Images.FirstOrDefault(c => c.Id == id);
            return image;
        }
    }
}
