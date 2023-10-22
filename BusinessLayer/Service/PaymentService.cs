
using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Model;
using System.Linq.Expressions;

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

        public void AddPayment(PaymentDTO paymentDTO)
        {
            try
            {
                Payment payment = _mapper.Map<Payment>(paymentDTO);
                _paymentRepository.Add(payment);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public IEnumerable<PaymentDTO> FindPayments(Expression<Func<Payment, bool>> predicate)
        {
            try
            {
                var payments = _paymentRepository.Find(predicate);
                return _mapper.Map<IEnumerable<PaymentDTO>>(payments);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public IEnumerable<PaymentDTO> GetAllPayments()
        {
            try
            {
                var payments = _paymentRepository.GetAll();
                return _mapper.Map<IEnumerable<PaymentDTO>>(payments);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<PaymentDTO> GetPaymentByAmountAsync(decimal amount)
        {
            try
            {
                var payment = await _paymentRepository.GetPaymentByAmountAsync(amount);
                return _mapper.Map<PaymentDTO>(payment);
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }

        public async Task<PaymentDTO> GetPaymentByBuildingIDAsync(int buildingId)
        {
            try
            {
                var payment = await _paymentRepository.GetPaymentByBuildingIDAsync(buildingId);
                return _mapper.Map<PaymentDTO>(payment);
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }

        public async Task<PaymentDTO> GetPaymentByDateTimeAsync(DateTime dateTime)
        {
            try
            {
                var payment = await _paymentRepository.GetPaymentByDateTimeAsync(dateTime);
                return _mapper.Map<PaymentDTO>(payment);

            }
            catch (Exception ex) 
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;

            }
        }

        public PaymentDTO GetPaymentById(int id)
        {
            try
            {
                var payment = _paymentRepository.Get(id);
                return _mapper.Map<PaymentDTO>(payment);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<PaymentDTO> GetPaymentByIdAsync(int id)
        {
            try
            {
                var payment = await _paymentRepository.GetPaymentByIdAsync(id);
                return _mapper.Map<PaymentDTO>(payment);
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }

        public void RemovePayment(int id)
        {
            try
            {
                var payment = _paymentRepository.Get(id);
                if (payment != null)
                {
                    _paymentRepository.Remove(payment);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void UpdatePayment(PaymentDTO paymentDTO)
        {
            try
            {
                Payment payment = _mapper.Map<Payment>(paymentDTO);
                _paymentRepository.Update(payment);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
