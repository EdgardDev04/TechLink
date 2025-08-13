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
    public class ShippingRepository : IShippingRepository
    {
        private readonly TechLinkDbContext _context;

        public ShippingRepository(TechLinkDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Shipping entity)
        {
            _context.Shipping.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Shipping entity)
        {
            _context.Shipping.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Shipping>> GetAllAsync()
        {
            return await _context.Shipping.ToListAsync();
        }

        public async Task<Shipping?> GetByIdAsync(int id)
        {
            var shippingExist = await _context.Shipping.FirstOrDefaultAsync(s => s.Id == id);

            if (shippingExist != null)
            {
                throw new Exception("Shipping does not exist");
            }

            return shippingExist;
        }

        public async Task<Shipping?> GetByTrackingNumberAsync(string trackingNumber)
        {
            var shippingExist = await _context.Shipping.FirstOrDefaultAsync(s => s.TrackingNumber == trackingNumber);

            if (shippingExist != null)
            {
                throw new Exception("Shipping does not exist");
            }

            return shippingExist;
        }

        public async Task UpdateAsync(Shipping entity)
        {
            _context.Shipping.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
