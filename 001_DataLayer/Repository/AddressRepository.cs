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
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(DataBaseContext context) : base(context)
        {

        }

        public async Task<Address> GetBuildingByAddressIdAsync(int id)
        {
            var result = await  _context.Addresses.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }

        public Address GetBuildingByAddressId(int id)
        {
            var result =  _context.Addresses.FirstOrDefault(i => i.Id == id);
            return result;
        }

        public async Task<IEnumerable<Address>> GetBuildingsByCityAsync(string city)
        {
            var results = await _context.Addresses
                         .Where(i => i.City == city)
                         .ToListAsync();

            return results;
        }

        public async Task<IEnumerable<Address>> GetBuildingsByCountryAsync(string country)
        {
            var results = await _context.Addresses
                         .Where(i => i.Country == country)
                         .ToListAsync();

            return results;
        }

        public async Task<IEnumerable<Address>> GetBuildingsByDistrictAsync(string district)
        {
            var results = await _context.Addresses
                        .Where(i => i.District == district)
                        .ToListAsync();

            return results;
        }

        public async Task<IEnumerable<Address>> GetBuildingsByHouseTypeAsync(string house, string country)
        {
            if(house == null)
            {
                var resultsByHouse = await _context.Addresses
                        .Where(i => i.Country == country)
                        .ToListAsync();

                return resultsByHouse;
            }

            var results = await _context.Addresses
                        .Where(i => i.House == house)
                        .ToListAsync();

            return results;
        }

        public Task<int> GetBuildingsCountByCityAsync(string city)
        {
            throw new NotImplementedException();
        }

        //public async Task<int> GetBuildingsCountByCityAsync(string city)
        //{
        //    var count = await _context.Addresses
        //        .Where(a => a.City == city)
        //        .Include(a => a.Building) 
        //        .SelectMany(a => a.Building) 
        //        .CountAsync();

        //    return count;
        //}

    }

}
