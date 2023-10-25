using AutoMapper;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapper
{
    public class BuildingProfile : Profile
    {
        public BuildingProfile()
        {
            CreateMap<BuildingDTO, Building>();
            CreateMap<Building, BuildingDTO>();
        }
    }
}
