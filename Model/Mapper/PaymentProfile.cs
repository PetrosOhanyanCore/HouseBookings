
using AutoMapper;
using Entity;

namespace Model.Mapper
{
    internal class PaymentProfile : Profile
    {
        public PaymentProfile() 
        {
            CreateMap<Payment, PaymentDTO>();

            CreateMap<PaymentDTO, Payment>();
        }
    }
}
