using AutoMapper;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapper
{
    public class BookingProfile:Profile
    {
        public BookingProfile()
        {
            CreateMap<BookingDTO, Booking>();

            CreateMap<Booking, BookingDTO>();
        }
    }
}
