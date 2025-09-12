using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Payment.Request;
using TechLink.Application.Dtos.Payment.Response;

namespace TechLink.Application.Contracts
{
    public interface IPaymentService
    {
        Task<GetPaymentByIdDto> GetByIdAsync(int id);
        Task<IEnumerable<GetPaymentByOrderIdDto>> GetByOrderIdAsync(int orderId);
        Task<int> ProcessPaymentAsync(CreatePaymentDto paymentDto);
        Task<bool> RefundPaymentAsync(int paymentId);
        Task<bool> ValidatePaymentStatusAsync(int paymentId);
        Task<bool> CancelPaymentAsync(int paymentId);
        Task<List<GetPaymentsByUserIdDto>> GetPaymentsByUserIdAsync(int userId);
    }
}
