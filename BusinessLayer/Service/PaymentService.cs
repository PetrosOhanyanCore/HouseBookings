
using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Model.DTO;

namespace BusinessLayer.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;
        public PaymentService(IPaymentRepository paymentRepository, IMapper mapper)
        {
            this._paymentRepository = paymentRepository;
            this._mapper = mapper;
        }

        public async Task AddPaymentAsync(PaymentDTO paymentDTO)
        {
                Payment payment = _mapper.Map<Payment>(paymentDTO);
                await _paymentRepository.AddAsync(payment);
        }

        

        public async Task<IEnumerable<PaymentDTO>> GetAllPaymentsAsync()
        {
                var payments = await _paymentRepository.GetAllAsync();
                return _mapper.Map<IEnumerable<PaymentDTO>>(payments);
         
        }

        public async Task<PaymentDTO> GetPaymentByAmountAsync(decimal amount)
        {
           
                var payment = await _paymentRepository.GetPaymentByAmountAsync(amount);
                return _mapper.Map<PaymentDTO>(payment);
        }

        public async Task<PaymentDTO> GetPaymentByBuildingIDAsync(int buildingId)
        {
                var payment = await _paymentRepository.GetPaymentByBuildingIDAsync(buildingId);
                return _mapper.Map<PaymentDTO>(payment);
        }

        public async Task<PaymentDTO> GetPaymentByDateTimeAsync(DateTime dateTime)
        {
                var payment = await _paymentRepository.GetPaymentByDateTimeAsync(dateTime);
                return _mapper.Map<PaymentDTO>(payment);
        }

     
        public async Task<PaymentDTO> GetPaymentByIdAsync(int id)
        {
                var payment = await _paymentRepository.GetPaymentByIdAsync(id);
                return _mapper.Map<PaymentDTO>(payment);
         
        }

        public async Task RemovePaymentAsync(int id)
        {
                var payment = _paymentRepository.Get(id);
                if (payment != null)
                {
                   await _paymentRepository.RemoveAsync(payment);
                }
        }

        public async Task UpdatePaymentAsync(PaymentDTO paymentDTO)
        {
                Payment payment = _mapper.Map<Payment>(paymentDTO);
                await _paymentRepository.UpdateAsync(payment);
            
        }
    }
}
