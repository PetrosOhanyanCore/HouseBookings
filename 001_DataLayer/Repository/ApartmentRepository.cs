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

        public async Task AddApartmentAsync(Apartment apartment)
        {
            _context.Apartments.Add(apartment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteApartmentAsync(Apartment apartment)
        {
            _context.Apartments.Remove(apartment);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Apartment> GetAllApartments(int buildingId)
        {
            List<Apartment> models = _context.Apartments
            .Where(p => p.BuildingId == buildingId)
            .ToList();

            return models;
        }

        public async Task<IEnumerable<Apartment>> GetAllApartmentsAsync(int buildingId)
        {
            List<Apartment> models =  await _context.Apartments
            .Where(p => p.BuildingId == buildingId)
            .ToListAsync();

            return models;
        }

        public async Task<Apartment> GetApartmentByIdAsync(int id)
        {
            var result = await _context.Apartments.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsByBalconyCountAsync(int count)
        {
            var apartments = await _context.Apartments
                .Where(a => a.BalconyCount == count)
                .ToListAsync();

            return apartments;
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsByBuildingIdAsync(int buildingId)
        {
            var apartments = await _context.Apartments
                .Where(a => a.BuildingId == buildingId)
                .ToListAsync();

            return apartments;
        }
        public async Task<IEnumerable<Apartment>> GetApartmentsByFloorAsync(int floor)
        {
            return await _context.Apartments
                .Where(a => a.Floor == floor)
                .ToListAsync();
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsByFloorCountAsync(int floorCount)
        {
            var apartments = await _context.Apartments
                .Where(a => a.FloorCount == floorCount)
                .ToListAsync();

            return apartments;
        }
        public async Task<IEnumerable<Apartment>> GetApartmentsByFloorHeightAsync(double floorHeight)
        {
            var apartments = await _context.Apartments
                .Where(a => a.FloorHeight == floorHeight)
                .ToListAsync();

            return apartments;
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsByKitchenAreaAsync(double area)
        {
            var apartments = await _context.Apartments
                .Where(a => a.KitchenArea == area)
                .ToListAsync();

            return apartments;
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsByLivingRoomAreaAsync(double area)
        {
            var apartments = await _context.Apartments
                .Where(a => a.LivingRoomArea == area)
                .ToListAsync();

            return apartments;
        }

        
        public  async Task<IEnumerable<Apartment>> GetApartmentsByNumberAsync(string number)
        {
            return await _context.Apartments
                .Where(a => a.Number == number)
                .ToListAsync();
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
        {
            return await _context.Apartments
                .Where(a => a.Price >= minPrice && a.Price <= maxPrice)
                .ToListAsync();
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsByRoomsCountAsync(int roomsCount)
        {
            return await _context.Apartments
                .Where(a=> a.RoomsCount == roomsCount)
                .ToArrayAsync();
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsBySectionAsync(string section)
        {
            return await _context.Apartments
                .Where(a => a.Section == section)
                .ToArrayAsync();
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsByTranslationIdAsync(int translationId)
        {
            return await _context.Apartments
                .Where(a => a.TranslationId == translationId)
                .ToArrayAsync();
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsWithAttachedKitchenAsync()
        {
            return await _context.Apartments
                .Where(a => a.IsKitchenAttached)
                .ToListAsync();
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsWithOptionAsync(string optionName)
        {
            return await _context.Apartments
                .Where(a => a.Options.Any(o => o.Discription == optionName))
                .ToListAsync();
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsWithParkingSpaceAsync()
        {
            return await _context.Apartments
                .Where(a => a.IsParkingSpaceExist  == true)
                .ToListAsync();
        }


        public async Task<IEnumerable<Apartment>> GetAvailableApartmentsAsync()
        {
            return await _context.Apartments.
                Where(a => a.IsAvailable == true)
                .ToListAsync();
        }

        public  async Task<ICollection<ApartmentImage>> GetImagesAsync(int apartmentId)
        {
            //var images = await _context.Images
            //.Where(p => p.ApartmentId == apartmentId)
            //.ToListAsync();

            //return images;
            var images = await _context.ApartmentImages
                .Where(p => p.ApartmentId == apartmentId)
                .ToListAsync();  
            return images;
        }

        public async Task<IEnumerable<Apartment>> GetPenthouseApartmentsAsync()
        {
            return await _context.Apartments
                .Where(a => a.IsPentHouse == true)
                .ToListAsync();
        }

        public async Task<IEnumerable<Apartment>> GetStudioApartmentsAsync()
        {
            return await _context.Apartments.
                Where(a => a.IsStudio == true)
                .ToListAsync();
        }


        public async Task<IEnumerable<Apartment>> GetTownhouseApartmentsAsync()
        {
            return await _context.Apartments.
                Where(a => a.IsTownHouse == true)
                .ToListAsync();
        }

        public int ImagesCountByImageId(int id)
        {
            var count = _context.Apartments
                            .Include(i => i.ApartmentImages)
                            .Where(p => p.ApartmentImages
                                .Any(s => s.Id == id))
                            .SelectMany(s => s.ApartmentImages)
                            .Count();
            return count;
        }

        public async Task<int> ImagesCountByImageIdAsync(int id)
        {
            var count = await _context.Apartments
                .Include(i => i.ApartmentImages)
                .Where(p => p.ApartmentImages.Any(s => s.Id == id))
                .SelectMany(s => s.ApartmentImages)
                .CountAsync();

            return count;
        }

        public async Task<bool> IsApartmentAvailableAsync(int apartmentId)
        {
            var apartment = await _context.Apartments.FindAsync(apartmentId);
            return apartment != null;
        }

        public async Task UpdateApartmentAsync(Apartment apartment)
        {
            _context.Entry(apartment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
