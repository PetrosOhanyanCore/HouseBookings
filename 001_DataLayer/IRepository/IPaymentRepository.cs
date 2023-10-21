using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    internal interface IPaymentRepository : IRepositoryBase<Payment>
    {
        Task<Payment> GetPaymentByIdAsync(int id);
        Task<Payment> GetPaymentByBuildingIDAsync(int buildingId);
        Task<Payment> GetPaymentByDateTimeAsync(DateTime dateTime);
        Task<Payment> GetPaymentByAmountAsync(decimal amount);
    }
}
