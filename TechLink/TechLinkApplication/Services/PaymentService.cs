using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Payment.Request;
using TechLink.Application.Dtos.Payment.Response;
using TechLink.Domain.Interfaces;

namespace TechLink.Application.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> CancelPaymentAsync(int paymentId)
        {
            throw new NotImplementedException();
        }

        public Task<GetPaymentByIdDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetPaymentByOrderIdDto>> GetByOrderIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetPaymentsByUserIdDto>> GetPaymentsByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<int> ProcessPaymentAsync(CreatePaymentDto paymentDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RefundPaymentAsync(int paymentId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidatePaymentStatusAsync(int paymentId)
        {
            throw new NotImplementedException();
        }
    }
}
