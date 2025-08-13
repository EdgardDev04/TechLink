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

        public async Task DeleteAsync(Payment entity)
        {
            _context.Payment.Remove(entity);
            await _context.SaveChangesAsync();  
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

        public async Task<Payment?> GetPaymentByOrderIdAsync(int orderId)
        {
            var getpayment = await _context.Payment.FirstOrDefaultAsync(x => x.OrderId == orderId);

            if (getpayment != null)
            {
                return getpayment;
            }

            return null;
        }

        public async Task UpdateAsync(Payment entity)
        {
            _context.Payment.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
