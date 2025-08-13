using Microsoft.EntityFrameworkCore;
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
    public class CartItemRepository : ICartItemRepository
    {
        private readonly TechLinkDbContext _context;

        public CartItemRepository(TechLinkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CartItem entity)
        {
            _context.CartItem.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(CartItem entity)
        {
            _context.CartItem.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CartItem>> GetAllAsync()
        {
            return await _context.CartItem.ToListAsync();
        }

        public Task<CartItem?> GetByIdAsync(int id)
        {
            var cartitemExist = _context.CartItem.FirstOrDefaultAsync(u => u.Id == id);

            if (cartitemExist == null)
            {
                throw new Exception("cart item does not exist");
            }

            return cartitemExist;
        }

        public async Task<IEnumerable<CartItem>> GetItemsByCartIdAsync(int cartId)
        {
            var cartExist = await _context .Cart.AnyAsync(u => u.Id == cartId);

            if (!cartExist)
            {
                throw new Exception("Cart does not exist");
            }

            return await _context.CartItem.Where(c => c.CartId == cartId).ToListAsync();
        }

        public async Task UpdateAsync(CartItem entity)
        {
            _context.CartItem.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
