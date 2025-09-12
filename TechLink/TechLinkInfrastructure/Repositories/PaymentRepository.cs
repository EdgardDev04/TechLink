using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechLink.Domain.Entities;
using TechLink.Domain.Interfaces;
using TechLink.Infrastructure.Data;

namespace TechLink.Infrastructure.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly TechLinkDbContext _context;

        public PaymentRepository(TechLinkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Payment entity)
        {
            _context.Payment.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var payment = await _context.Payment.FindAsync(id);

            if (payment != null)
            {
                _context.Payment.Remove(payment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Payment>> GetAllAsync()
        {
            return await _context.Payment.ToListAsync();
        }

        public async Task<Payment?> GetByIdAsync(int id)
        {
            var getpayment = await _context.Payment.FirstOrDefaultAsync(x => x.Id == id);
            
            if (getpayment != null)
            {
                return getpayment;
            }

            return null;
        }

        public Task<List<Payment>> GetByOrderIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public async Task<Payment?> GetPaymentByOrderIdAsync(int orderId)
        {
            var getpayment = await _context.Payment.FirstOrDefaultAsync(x => x.OrderId == orderId);

            if (getpayment != null)
            {
                return getpayment;
            }

            return null;
        }

        public Task<List<Payment>> GetPaymentsByDateRangeAsync(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<List<Payment>> GetPaymentsByStatusAsync(bool isSuccessful)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PaymentExistsAsync(int orderId, decimal amount, DateTime paidAt)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Payment entity)
        {
            _context.Payment.Update(entity);
            await _context.SaveChangesAsync();
        }

        Task<List<Payment>> IPaymentRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
