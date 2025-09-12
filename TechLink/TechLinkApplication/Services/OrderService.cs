using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Order.Request;
using TechLink.Application.Dtos.Order.Response;
using TechLink.Application.Dtos.Payment.Request;
using TechLink.Domain.Enums;

namespace TechLink.Application.Services
{
    public class OrderService : IOrderService
    {
        public Task<bool> ApplyCouponAsync(int orderId, string couponCode)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> CalculateOrderTotalAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CancelOrderAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ConfirmOrderAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(CreateOrderDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetAllOrderDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetOrderByIdDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetOrderByUserIdDto>> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetOrderByStatusDto>> GetOrdersByStatusAsync(StatusOrder status)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ProcessPaymentAsync(int orderId, ProcessPaymentDto payment)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, UpdateOrderDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderStatusAsync(int orderId, StatusOrder newStatus)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateOrderStockAsync(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
