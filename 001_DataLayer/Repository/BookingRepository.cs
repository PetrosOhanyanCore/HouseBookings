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
    public class BookingRepository :
        RepositoryBase<Booking>,
        IBookingRepository
    {
        public BookingRepository(DataBaseContext context)
            : base(context)
        {
        }
        public IEnumerable<Booking> GetAllBookings(int buildingId)
        {
            var result = _context.Bookings.Where(p => p.Apartment.BuildingId == buildingId);
            return result;
        }
        public async Task<Booking> GetBookingByIdAsync(int id)
        {
            var booking = await _context.Bookings.FirstOrDefaultAsync(c => c.Id == id);
            return booking;
        }
        public Booking GetBookingByID(int id)
        {
            var booking = _context.Bookings.FirstOrDefault(c => c.Id == id);
            return booking;
        }

        public Task<Booking> GetBuildingByAddressIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Booking GetBuildingByAddressId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Booking>> GetBuildingsByCountryAsync(string Apartment)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Booking>> GetBuildingsByCityAsync(string Description)
        {
            throw new NotImplementedException();
        }
    }
}

