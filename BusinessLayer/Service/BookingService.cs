using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;

        public BookingService(
            IBookingRepository bookingRepository,
            IMapper mapper)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
        }
    }
}
