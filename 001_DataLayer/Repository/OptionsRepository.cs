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
    public class OptionsRepository
        : RepositoryBase<Options>,
        IOptionsRepository
    {
        public OptionsRepository(DataBaseContext context)
            : base(context)
        {
        }



       public async Task<Options> GetOptionByIdAsync(int id)
        {
            var result = await _context.Options.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }

        public async Task<Apartment> GetApartmentByIdAsync(int id)
        {
            var result = await _context.Apartments.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }

        public async Task<Building> GetBuildingByIdAsync(int id)
        {
            var result = await _context.Buildings.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }
    }
}

