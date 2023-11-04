using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Model;

namespace BusinessLayer.Service
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;

        public BookingService(IBookingRepository bookingRepository, IMapper mapper)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
        }

        public async Task AddBookingAsync(BookingDTO bookingDTO)
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

        public async Task RemoveBookingAsync(BookingDTO bookingDTO)
        {
            var booking = _mapper.Map<BookingDTO, Booking>(bookingDTO);
            if (booking != null)
            {
                _bookingRepository.Remove(booking);
            }
        }

        public async Task UpdateBookingAsync(BookingDTO bookingDTO)
        {
            var booking = _mapper.Map<BookingDTO, Booking>(bookingDTO);
            _bookingRepository.Update(booking);
        }
    }
}
