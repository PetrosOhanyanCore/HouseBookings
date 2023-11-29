using Entity;
using Model.DTO;
using System.Linq.Expressions;

namespace BusinessLayer.IService
{
    public interface IPaymentService
    {
        Task<PaymentDTO> GetPaymentByIdAsync(int id);
        Task<PaymentDTO> GetPaymentByBuildingIDAsync(int buildingId);
        Task<PaymentDTO> GetPaymentByDateTimeAsync(DateTime dateTime);
        Task<PaymentDTO> GetPaymentByAmountAsync(decimal amount);
        Task<IEnumerable<PaymentDTO>> GetAllPaymentsAsync();
     
        Task AddPaymentAsync(PaymentDTO paymentDTO);
        Task UpdatePaymentAsync(PaymentDTO paymentDTO);
        Task RemovePaymentAsync(int id);
    }
}
