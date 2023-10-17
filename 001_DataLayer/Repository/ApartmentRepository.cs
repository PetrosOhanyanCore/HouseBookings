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
    public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
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

        public Task<Apartment> GetApartmentByIdAsync(int id)
        {
            return _context.Apartments.FirstOrDefaultAsync(i => i.Id == id);
        }

        public /*async*/ Task<ICollection<Image>> GetImages(int apartmentId)
        {
            //    var images = await _context.Images
            //    .Where(p => p.ApartmentId == apartmentId)
            //    .ToListAsync();

            //    return images;
            return null;
        }

        public int ImagesCountByImageId(int id)
        {
            var count = _context.Apartments
                            .Include(i => i.Images)
                            .Where(p => p.Images.Any(s => s.Id == id))
                            .SelectMany(s => s.Images)
                            .Count();

            return count;
        }
    }
}
