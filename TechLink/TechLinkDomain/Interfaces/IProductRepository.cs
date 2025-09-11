using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetByCategoryIdAsync(int categoryId);
        Task<List<Product>> SearchAsync(string keyword);
    }

}
