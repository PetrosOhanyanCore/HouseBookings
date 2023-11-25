using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IService
{
    public interface IBookingService
    {
        void AddBooking(BookingDTO booking);

        Task<BookingDTO> GetBookingAsync(int id);
        IEnumerable<BookingDTO> GetAllBooking(int buildingId);
        Task<IEnumerable<BookingDTO>> GetAllBookingsInEndTimeAsync(DateTime endTime);
        Task<IEnumerable<BookingDTO>> GetAllBookingsInCanceledAsync(DateTime canceledTime);

        Task AddBookingAsync(BookingDTO bookingDTO);
        Task RemoveBookingAsync(BookingDTO bookingDTO);
        Task UpdateBookingAsync(BookingDTO bookingDTO);
    }
}


