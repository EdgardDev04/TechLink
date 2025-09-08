using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechLink.Domain.Entities;
using TechLink.Domain.Interfaces;
using TechLink.Infrastructure.Data;

namespace TechLink.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly TechLinkDbContext _context;
        public ProductRepository(TechLinkDbContext context) 
        {
            _context = context;
        }

        public async Task AddAsync(Product entity)
        {
            _context.Product.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Product.FindAsync(id);

            if (product != null)
            {
                _context.Product.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetByCategoryIdAsync(int categoryId)
        {
            var products = await _context.Product.Where(p => p.CategoryId == categoryId).ToListAsync();

            if (!products.Any())
            {
                throw new Exception("No products found for the given category");
            }

            return products;
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            var getProduct = await _context.Product.FirstOrDefaultAsync(u => u.Id == id);

            if (getProduct == null)
            {
                throw new Exception("Product does not exist");
            }
            return getProduct;
        }

        public async Task<IEnumerable<Product>> SearchAsync(string keyword)
        {
            var products = await _context.Product.
                Where(p => p.Name.Contains(keyword) || p.Brand.Contains(keyword) || p.Description.Contains(keyword)).ToListAsync();

            if (!products.Any())
            {
                return new List<Product>();
            }

            return products;
        }

        public async Task UpdateAsync(Product entity)
        {
            _context.Product.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
