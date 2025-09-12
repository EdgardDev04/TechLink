using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;
using TechLink.Domain.Enums;

namespace TechLink.Domain.Interfaces
{
    public interface IOrderRepository 
    {
        Task<Order> GetByIdAsync(int id);
        Task<List<Order>> GetByUserIdAsync(int userId);
        Task<List<Order>> GetAllAsync();
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
        Task DeleteAsync(int id);
        Task<List<Order>> GetOrdersByStatusAsync(StatusOrder status);
        Task<Order> GetOrderWithDetailsAsync(int id);
    }

}