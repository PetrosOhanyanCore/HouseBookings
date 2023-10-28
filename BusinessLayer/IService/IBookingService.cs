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
        Task<BookingDTO> GetBookingAsync(int id);
        IEnumerable<BookingDTO> GetAllBooking(int buildingId);
        Task<IEnumerable<BookingDTO>> GetAllBookingsInEndTimeAsync(DateTime endTime);
        Task<IEnumerable<BookingDTO>> GetAllBookingsInCanceledAsync(DateTime canceledTime);

        void AddBookingAsync(BookingDTO bookingDTO);
        void RemoveBookingAsync(BookingDTO bookingDTO);
        void UpdateBookingAsync(BookingDTO bookingDTO);
    }
}


