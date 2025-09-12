using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface IPaymentRepository
    {
        Task<Payment> GetByIdAsync(int id);
        Task<List<Payment>> GetByOrderIdAsync(int orderId);
        Task<List<Payment>> GetAllAsync();
        Task AddAsync(Payment payment);
        Task UpdateAsync(Payment payment);
        Task DeleteAsync(int id);
        Task<List<Payment>> GetPaymentsByStatusAsync(bool isSuccessful);
        Task<List<Payment>> GetPaymentsByDateRangeAsync(DateTime from, DateTime to);
        Task<bool> PaymentExistsAsync(int orderId, decimal amount, DateTime paidAt);
    }

}
