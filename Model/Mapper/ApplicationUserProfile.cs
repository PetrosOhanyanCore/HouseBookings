using AutoMapper;
using Entity;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapper
{
    public class ApplicationUserProfile : Profile
    {
        public ApplicationUserProfile()
        {
            CreateMap<ApplicationUserDTO,ApplicationUser>();
            CreateMap<ApplicationUser,ApplicationUserDTO>();
        }
    }
}
