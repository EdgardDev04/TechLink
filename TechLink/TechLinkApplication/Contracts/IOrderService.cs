using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Order.Request;
using TechLink.Application.Dtos.Order.Response;
using TechLink.Application.Dtos.Payment.Request;
using TechLink.Domain.Enums;

namespace TechLink.Application.Contracts
{
    public interface IOrderService
    {
        Task<GetOrderByIdDto> GetByIdAsync(int id);
        Task<List<GetAllOrderDto>> GetAllAsync();
        Task<List<GetOrderByUserIdDto>> GetByUserIdAsync(int userId);
        Task<int> CreateAsync(CreateOrderDto dto);
        Task UpdateAsync(int id, UpdateOrderDto dto);
        Task DeleteAsync(int id);
        Task<bool> CancelOrderAsync(int orderId);
        Task<bool> ConfirmOrderAsync(int orderId);
        Task<decimal> CalculateOrderTotalAsync(int orderId);
        Task<bool> ApplyCouponAsync(int orderId, string couponCode);
        Task<bool> ValidateOrderStockAsync(int orderId);
        Task<bool> ProcessPaymentAsync(int orderId, ProcessPaymentDto payment);
        Task<List<GetOrderByStatusDto>> GetOrdersByStatusAsync(StatusOrder status);
        Task<bool> UpdateOrderStatusAsync(int orderId, StatusOrder newStatus);
    }
}
