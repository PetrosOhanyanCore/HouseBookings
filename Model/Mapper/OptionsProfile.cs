using AutoMapper;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapper
{
    public class OptionsProfile : Profile
    {

        public OptionsProfile()
        {
            CreateMap<OptionsDTO, Options>();

            CreateMap<Options, OptionsDTO>();
        }
    }
}
