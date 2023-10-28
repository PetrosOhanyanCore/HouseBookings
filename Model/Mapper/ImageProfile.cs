using AutoMapper;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapper
{
    public class ImageProfile : Profile
    {
        ImageProfile()
        {
            CreateMap<ApartmentImageDTO, ApartmentImage>();

            CreateMap<ApartmentImage, ApartmentImageDTO>();
        }
    }
}
