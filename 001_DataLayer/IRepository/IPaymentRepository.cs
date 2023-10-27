using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IPaymentRepository : IRepositoryBase<Payment>
    {
        Task<Payment> GetPaymentByIdAsync(int id);
        Task<Payment> GetPaymentByBuildingIDAsync(int buildingId);
        Task<Payment> GetPaymentByDateTimeAsync(DateTime dateTime);
        Task<Payment> GetPaymentByAmountAsync(decimal amount);
        Task AddAsync(Payment payment);
        Task<IEnumerable<Payment>> GetAllAsync();
        Task RemoveAsync(Payment payment);
        Task UpdateAsync(Payment payment);


    }
}
