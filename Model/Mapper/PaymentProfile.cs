
using AutoMapper;
using Entity;
using Model.DTO;

namespace Model.Mapper
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile() 
        {
            CreateMap<Payment, PaymentDTO>();

            CreateMap<PaymentDTO, Payment>();
        }
    }
}
