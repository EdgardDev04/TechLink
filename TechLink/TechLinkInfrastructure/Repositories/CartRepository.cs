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
    public class CartRepository : ICartRepository
    {
        private readonly TechLinkDbContext _context;

        public CartRepository (TechLinkDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Cart entity)
        {
            _context.Cart.Add(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var cart = await _context.Cart.FindAsync(id);
            if (cart != null)
            {
                _context.Cart.Remove(cart);
                await _context.SaveChangesAsync();
            }
        }

        public Task<bool> ExistsByUserIdAsync(int userId)
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

        public Task<Cart> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Cart?> GetCartByUserIdAsync(int userId)
        {
            var cartExist = await _context.Cart.FirstOrDefaultAsync(x => x.UserId == userId);

            if (cartExist == null)
            {
                throw new Exception("Cart does not exist");
            }

            return cartExist;
        }
        public async Task UpdateAsync(Cart entity)
        {
            _context.Cart.Update(entity);
            await _context.SaveChangesAsync();
        }

        Task<List<Cart>> ICartRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
