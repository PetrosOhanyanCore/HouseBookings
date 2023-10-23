using Entity;
using Model;
using System.Linq.Expressions;

namespace BusinessLayer.IService
{
    public interface IPaymentService
    {
        Task<PaymentDTO> GetPaymentByIdAsync(int id);
        Task<PaymentDTO> GetPaymentByBuildingIDAsync(int buildingId);
        Task<PaymentDTO> GetPaymentByDateTimeAsync(DateTime dateTime);
        Task<PaymentDTO> GetPaymentByAmountAsync(decimal amount);
        IEnumerable<PaymentDTO> GetAllPayments();
        IEnumerable<PaymentDTO> FindPayments(Expression<Func<Payment, bool>> predicate);
        PaymentDTO GetPaymentById(int id);
        void AddPayment(PaymentDTO paymentDTO);
        void UpdatePayment(PaymentDTO paymentDTO);
        void RemovePayment(int id);
    }
}
