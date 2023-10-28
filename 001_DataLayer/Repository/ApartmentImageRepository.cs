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
    public class ApartmentImageRepository :
        RepositoryBase<ApartmentImage>,
        IApartmentImageRepository
    {
        public ApartmentImageRepository(DataBaseContext context)
            : base(context)
        {
        }

        //public IEnumerable<Image<Type>> GetAllImages(int buildingId)
        //{
        //    var result = _context.Images.Where(p => p.PropertyId == buildingId).ToList();
        //    return result;
        //}

        public async Task<ApartmentImage> GetImageByIdAsync(int id)
        {
            var image = await _context.Images.FirstOrDefaultAsync(c => c.Id == id);
            return image;
        }

        public ApartmentImage GetImageByID(int id)
        {
            var image = _context.Images.FirstOrDefault(c => c.Id == id);
            return image;
        }

        public IEnumerable<ApartmentImage> GetAllImages(int buildingId)
        {
            throw new NotImplementedException();
        }
    }
}
