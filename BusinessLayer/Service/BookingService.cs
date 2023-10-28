using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repository;
using System.Linq.Expressions;

namespace BusinessLayer.Service
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;

        public BookingService(IBookingRepository bookingRepository,IMapper mapper)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
        }

        public void AddBookingAsync(BookingDTO bookingDTO)
        {
            var booking = _mapper.Map<BookingDTO, Booking>(bookingDTO);
            _bookingRepository.Add(booking);
        }

        public IEnumerable<BookingDTO> GetAllBooking(int buildingId)
        {
            var bookings = _bookingRepository.GetAllBookings(buildingId);
            return _mapper.Map<IEnumerable<Booking>, IEnumerable<BookingDTO>>(bookings);
        }

        public async Task<IEnumerable<BookingDTO>> GetAllBookingsInEndTimeAsync(DateTime endTime)
        {
            var bookings = await _bookingRepository.GetAllBookingInEndDateAsync(endTime);
            return _mapper.Map<IEnumerable<Booking>, IEnumerable<BookingDTO>>(bookings);
        }

        public async Task<IEnumerable<BookingDTO>> GetAllBookingsInCanceledAsync(DateTime canceledTime)
        {
            var bookings = await _bookingRepository.GetAllBookingInCancelationDateAsync(canceledTime);
            return _mapper.Map<IEnumerable<Booking>, IEnumerable<BookingDTO>>(bookings);
        }

        public async Task<BookingDTO> GetBookingAsync(int id)
        {
            var bookings = await _bookingRepository.GetBookingByIdAsync(id);
            return _mapper.Map<Booking, BookingDTO>(bookings);
        }

        public void RemoveBookingAsync(BookingDTO bookingDTO)
        {
            var booking = _mapper.Map<BookingDTO, Booking>(bookingDTO);
            if (booking != null)
            {
                _bookingRepository.Remove(booking);
            }
        }

        public void UpdateBookingAsync(BookingDTO bookingDTO)
        {
            var booking = _mapper.Map<BookingDTO, Booking>(bookingDTO);
            _bookingRepository.Update(booking);
        }
    }
}
