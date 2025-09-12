using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.OrderItem.Request;
using TechLink.Application.Dtos.OrderItem.Response;

namespace TechLink.Application.Services
{
    public class OrderItemService : IOrderItemService
    {
        public Task<decimal> CalculateTotalPriceAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(CreateOrderItemDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GetOrderItemByIdDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetOrderItemByOrderIdDto>> GetByOrderIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, UpdateOrderItemDto dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStockAfterOrderAsync(int orderItemId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateStockAvailabilityAsync(int productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
