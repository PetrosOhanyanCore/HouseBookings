using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entity;

namespace Model.Mapper
{
    public class ScoringProfile : Profile
    {

        public ScoringProfile()
        {
            CreateMap<Scoring, ScoringDTO>();

            CreateMap<ScoringDTO, Scoring>();
        }

    }
}
