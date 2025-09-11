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
        Task AddAsync(  int cartId, int productId, CartItem entity);
        Task UpdateAsync(int cartId, int productId, CartItem entity);
        Task DeleteAsync(int id);
        Task<List<CartItem>> GetItemsByCartIdAsync(int cartId);
    }

}
