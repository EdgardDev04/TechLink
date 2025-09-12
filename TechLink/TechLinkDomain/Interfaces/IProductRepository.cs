using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface IProductRepository 
    {
        Task<Product> GetByIdAsync(int id);
        Task<Product> GetByNameAsync(string name);
        Task<List<Product>> GetAllAsync();
        Task<List<Product>> GetByCategoryAsync(int categoryId);
        Task<List<Product>> GetByBrandAsync(string brand);
        Task<List<Product>> GetByPriceRangeAsync(decimal minPrice, decimal maxPrice);
        Task<List<Product>> SearchAsync(string searchTerm);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<bool> UpdateStockAsync(int productId, int newStock);
        Task<int> GetStockAsync(int productId);
        Task<bool> ProductExistsAsync(string name, string brand);
    }

}