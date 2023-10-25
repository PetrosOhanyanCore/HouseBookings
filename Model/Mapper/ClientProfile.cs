using AutoMapper;
using Entity;

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
