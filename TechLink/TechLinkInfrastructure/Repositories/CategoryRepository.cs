using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using TechLink.Domain.Entities;
using TechLink.Domain.Enums;
using TechLink.Domain.Interfaces;
using TechLink.Infrastructure.Data;

namespace TechLink.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TechLinkDbContext _context;
        public CategoryRepository(TechLinkDbContext context) 
        { 
            _context = context;    
        }

        public async Task AddAsync(Category entity)
        {
            _context.Category.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Category.FindAsync(id);
            if (entity == null)
            {
                _context.Category.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            var getCategory = await _context.Category.FindAsync(id);

            if (getCategory == null)
            {
                throw new Exception("category does not exist");
            }

            return getCategory;
        }

        public Task<Category> GetByNameAsync(CategoryType name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var products = await _context.Product.Where(p => p.CategoryId == categoryId).ToListAsync();

            if (!products.Any())
            {
                throw new Exception("No products found for the given category");
            }

            return products;
        }

        public async Task UpdateAsync(Category entity)
        {
            _context.Category.Update(entity);
            await _context.SaveChangesAsync();
        }

        Task<List<Category>> ICategoryRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
