using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataLayer.IRepository
{
    public interface IAddressRepository : IRepositoryBase<Address>
    {

        Task<Address> GetBuildingByAddressIdAsync(int id);
        Address GetBuildingByAddressId(int id);
        Task<IEnumerable<Address>> GetBuildingsByCountryAsync(string country);
        Task<IEnumerable<Address>> GetBuildingsByCityAsync(string city);

        Task<IEnumerable<Address>> GetBuildingsByDistrictAsync(string district);

        Task<IEnumerable<Address>> GetBuildingsByHouseTypeAsync(string? house , string country);

        Task<int> GetBuildingsCountByCityAsync(string city);



    }
}
