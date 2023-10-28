using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entity;

namespace Model.Mapper
{
    public class BuildingImageProfile : Profile
    {
        public BuildingImageProfile()
        {
            CreateMap<BuildingImageDTO, BuildingImage>();
            CreateMap<BuildingImage, BuildingImageDTO>();
        }
    }
}
