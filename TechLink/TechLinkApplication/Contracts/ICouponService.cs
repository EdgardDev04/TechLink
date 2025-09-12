using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Coupon.Request;
using TechLink.Application.Dtos.Coupon.Response;

namespace TechLink.Application.Contracts
{
    public interface ICouponService
    {
        Task<GetCouponByIdDto> GetByIdAsync(int id);
        Task<List<GetAllCouponDto>> GetAllAsync();
        Task<List<GetActiveCouponDto>> GetActiveCouponsAsync();
        Task<int> CreateAsync(CreateCouponDto dto);
        Task UpdateAsync(int id, UpdateCouponDto dto);
        Task DeleteAsync(int id);
        Task<bool> IsValidCouponAsync(string code);
        Task<decimal> ApplyDiscountAsync(string code, decimal totalAmount);
    }
}
