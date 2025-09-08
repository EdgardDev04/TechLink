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
    public class CouponRepository : ICouponRepository
    {
        private readonly TechLinkDbContext _context;

        public CouponRepository(TechLinkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Coupon entity)
        {
            _context.Coupon.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task ApplyCouponAsync(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var coupon = await _context.Coupon.FindAsync(id);
            if (coupon != null)
            {
                _context.Coupon.Remove(coupon);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Coupon>> GetAllAsync()
        {
            return await _context.Coupon.ToListAsync();
        }

        public async Task<Coupon?> GetByCodeAsync(string code)
        {
            var getCode = await _context.Coupon.FirstOrDefaultAsync(x => x.Code == code);

            if (getCode == null)
            {
                throw new Exception("Coupon does not exist");
            }

            return getCode;
        }

        public async Task<Coupon?> GetByIdAsync(int id)
        {
            var getCoupon = await _context.Coupon.FirstOrDefaultAsync(x => x.Id == id);

            if (getCoupon == null)
            {
                throw new Exception("Coupon does not exist");
            }

            return getCoupon;
        }

        public async Task UpdateAsync(Coupon entity)
        {
            _context.Coupon.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
