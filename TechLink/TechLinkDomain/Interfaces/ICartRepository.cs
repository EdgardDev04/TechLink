using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface ICartRepository 
    {
        Task<Cart> GetByIdAsync(int id);
        Task<Cart> GetByUserIdAsync(int userId);
        Task<List<Cart>> GetAllAsync();
        Task AddAsync(Cart cart);
        Task UpdateAsync(Cart cart);
        Task DeleteAsync(int id);
        Task<bool> ExistsByUserIdAsync(int userId);
    }

}
