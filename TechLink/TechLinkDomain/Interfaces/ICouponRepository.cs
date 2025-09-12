using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface ICouponRepository 
    {
        Task<Coupon> GetByIdAsync(int id);
        Task<Coupon> GetByCodeAsync(string code);
        Task<List<Coupon>> GetAllActiveAsync();
        Task<List<Coupon>> GetAllAsync();
        Task AddAsync(Coupon coupon);
        Task UpdateAsync(Coupon coupon);
        Task DeleteAsync(int id);
        Task<bool> ExistsByCodeAsync(string code);
    }

}
