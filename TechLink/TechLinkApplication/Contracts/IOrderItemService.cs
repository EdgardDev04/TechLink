using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.OrderItem.Request;
using TechLink.Application.Dtos.OrderItem.Response;

namespace TechLink.Application.Contracts
{
    public interface IOrderItemService
    {
        Task<GetOrderItemByIdDto> GetByIdAsync(int id);
        Task<List<GetOrderItemByOrderIdDto>> GetByOrderIdAsync(int orderId);
        Task<int> CreateAsync(CreateOrderItemDto dto);
        Task UpdateAsync(int id, UpdateOrderItemDto dto);
        Task DeleteAsync(int id);
        Task<decimal> CalculateTotalPriceAsync(int orderId);
        Task<bool> ValidateStockAvailabilityAsync(int productId, int quantity);
        Task UpdateStockAfterOrderAsync(int orderItemId);
    }
}
