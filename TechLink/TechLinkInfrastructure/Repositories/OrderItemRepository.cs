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
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly TechLinkDbContext _context;

        public OrderItemRepository(TechLinkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(OrderItem entity)
        {
             _context.OrderItem.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(OrderItem entity)
        {
            _context.OrderItem.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<OrderItem>> GetAllAsync()
        {
            return await _context.OrderItem.ToListAsync();
        }

        public Task<OrderItem?> GetByIdAsync(int id)
        {
            var getOrderItem = _context.OrderItem.FirstOrDefaultAsync(u => u.Id == id);

            if (getOrderItem == null)
            {
                throw new Exception("");
            }
            return getOrderItem;
        }

        public Task<IEnumerable<OrderItem>> GetItemsByOrderIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(OrderItem entity)
        {
            _context.OrderItem.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
