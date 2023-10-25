using DataLayer.IRepository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IOptionsRepository : IRepositoryBase<Options>
    {

        Task<Options> GetOptionByIdAsync(int id);
        Task<Apartment> GetApartmentByIdAsync(int id);
        Task<Building> GetBuildingByIdAsync(int id);
    }
}
