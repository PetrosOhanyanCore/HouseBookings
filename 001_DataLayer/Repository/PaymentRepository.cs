using DataLayer.IRepository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(DataBaseContext context) : base(context)
        {
        }

        public async Task<Payment> GetPaymentByIdAsync(int id)
        {
            var result = await _context.Payments.FirstOrDefaultAsync(i => i.Id == id);
            return result;
        }

        public async Task<Payment> GetPaymentByBuildingIDAsync(int buildingId)
        {
            var result = await _context.Payments.FirstOrDefaultAsync(i => i.BookingId == buildingId);
            return result;
        }

        public async Task<Payment> GetPaymentByDateTimeAsync(DateTime dateTime)
        {
            var result = await _context.Payments.FirstOrDefaultAsync(x => x.PaymentDate == dateTime);
            return result;
        }

        public async Task<Payment> GetPaymentByAmountAsync(decimal amount)
        {
            var result = await _context.Payments.FirstOrDefaultAsync(j => j.Amount == amount);
            return result;
        }

        public async Task AddAsync(Payment payment)
        {
            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Payment>> GetAllAsync()
        {
            return await _context.Payments.ToListAsync();
        }

        public async Task RemoveAsync(Payment payment)
        {
            _context.Payments.Remove(payment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Payment payment)
        {
            _context.Payments.Update(payment);
            await _context.SaveChangesAsync();
        }
    }
}
