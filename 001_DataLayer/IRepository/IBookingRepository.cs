using DataLayer.IRepository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IBookingRepository : IRepositoryBase<Booking>
    {
        Booking GetBookingByID(int id);
        Task<Booking> GetBookingByIdAsync(int id);
        Task<IEnumerable<Booking>> GetAllBookingInEndDateAsync(DateTime dateTime);
        Task<IEnumerable<Booking>> GetAllBookingInCancelationDateAsync(DateTime dateTime);
        IEnumerable<Booking> GetAllBookings(int buildingId);
    }
}
