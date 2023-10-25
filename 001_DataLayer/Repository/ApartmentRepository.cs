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
    public class ApartmentRepository
        : RepositoryBase<Apartment>,
        IApartmentRepository
    {
        public ApartmentRepository(DataBaseContext context)
            : base(context)
        {
        }

        public IEnumerable<Apartment> GetAllApartments(int buildingId)
        {
            List<Apartment> models = _context.Apartments
            .Where(p => p.BuildingId == buildingId)
            .ToList();

            return models;
        }

        public async Task<Apartment> GetApartmentByIdAsync(int id)
        {
            var result = await _context.Apartments.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }

        public  Task<ICollection<ApartmentImage>> GetImages(int apartmentId)
        {
            //var images = await _context.Images
            //.Where(p => p.ApartmentId == apartmentId)
            //.ToListAsync();

            //return images;
            return null;
        }

        public int ImagesCountByImageId(int id)
        {
            //var count = _context.Apartments
            //                .Include(i => i.ApartmentImages)
            //                .Where(p => p.ApartmentImages
            //                    .Any(s => s.Id == id))
            //                .SelectMany(s => s.ApartmentImages)
            //                .Count();
            var count = 0;
            return count;
        }
    }
}
