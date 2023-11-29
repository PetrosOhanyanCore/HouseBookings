using AutoMapper;
using Entity;
using Model.DTO;

namespace Model.Mapper
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientDTO>();

            CreateMap<ClientDTO, Client>().ForMember(dest => dest.LivingAddressId,
                opt => opt.Ignore());
        }
    }
}
