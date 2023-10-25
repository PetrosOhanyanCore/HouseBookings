
using AutoMapper;
using Entity;

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
