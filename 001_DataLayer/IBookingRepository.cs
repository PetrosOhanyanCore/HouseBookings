using DataLayer.Migrations;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IBookingRepository
    {

        Task<Booking> GetBuildingByAddressIdAsync(int id);
        Booking GetBuildingByAddressId(int id);
        Task<IEnumerable<Booking>> GetBuildingsByCountryAsync(string Apartment);
        Task<IEnumerable<Booking>> GetBuildingsByCityAsync(string Description);



    }
}
