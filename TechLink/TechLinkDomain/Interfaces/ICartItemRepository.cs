using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface ICartItemRepository 
    {
        Task<CartItem> GetByIdAsync(int id);
        Task<List<CartItem>> GetByCartIdAsync(int cartId);
        Task<List<CartItem>> GetAllAsync();
        Task AddAsync(CartItem cartItem);
        Task UpdateAsync(CartItem cartItem);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int cartId, int productId);
        Task<CartItem> GetByCartIdAndProductIdAsync(int cartId, int productId);
    }
}
