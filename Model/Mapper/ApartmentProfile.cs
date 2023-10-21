using AutoMapper;
using Entity;

namespace Model.Mapper
{
    public class ApartmentProfile : Profile
    {
        public ApartmentProfile()
        {
            CreateMap<ApartmentDTO, Apartment>();

            CreateMap<Apartment, ApartmentDTO>();
                //.ForMember(dest => dest.Building,
                //opt => opt.Ignore())
                //.ForMember(dest => dest.BalconyCount,
                //src => src.MapFrom(opt => opt.BalconyCount + 1));
        }
    }
}
