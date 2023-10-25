using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BookingRepository : RepositoryBase<Booking>
    {
        public BookingRepository(DataBaseContext context) : base(context)
        {
        }



        public async Task<Booking> GetBuildingByApartmentIdAsync(int id)
        {
            var result = await _context.Addresses.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }
    }
}
