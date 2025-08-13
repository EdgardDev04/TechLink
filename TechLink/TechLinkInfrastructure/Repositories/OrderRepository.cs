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
    public class OrderRepository : IOrderRepository
    {
        private readonly TechLinkDbContext _context;

        public OrderRepository(TechLinkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Order entity)
        {
            _context.Order.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Order entity)
        {
            _context.Order.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _context.Order.ToListAsync();
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            var getOrder = await _context.Order.FindAsync(id);

            if (getOrder != null)
            {
                throw new Exception();
            }

            return getOrder;
        }

        public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId)
        {
            var getUser = await _context.User.FindAsync(userId);

            if (getUser == null)
            {
                throw new Exception("Order does not exist");
            }

            return await _context.Order.Where(o => o.UserId == userId).ToListAsync();
        }

        public async Task UpdateAsync(Order entity)
        {
            _context.Order.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
