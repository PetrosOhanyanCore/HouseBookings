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

        public async Task<ICollection<ApartmentImage>> GetApartmentAllImagesAsync(int apartmentId)
        {
            var images = await _context.ApartmentImages
                       .Where(x => x.Id == apartmentId)
                       .ToListAsync();

            return images;
        }
        public void RemoveApartmentImageById(int apartmentImageId)
        {

            var image = Get(apartmentImageId);
            if (image != null)
            {
                Remove(image);
            }
        }
    }
}
