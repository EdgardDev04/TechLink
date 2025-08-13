using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;
using TechLink.Domain.Interfaces;
using TechLink.Infrastructure.Data;

namespace TechLink.Infrastructure.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly TechLinkDbContext _context;

        public CartRepository (TechLinkDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(Cart entity)
        {
            throw new NotImplementedException();
        }
        public Task DeleteAsync(Cart entity)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Cart>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Cart?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Cart?> GetCartByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }
        public Task UpdateAsync(Cart entity)
        {
            throw new NotImplementedException();
        }
    }
}
