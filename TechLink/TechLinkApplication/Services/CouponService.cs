using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Coupon.Request;
using TechLink.Application.Dtos.Coupon.Response;

namespace TechLink.Application.Services
{
    public class CouponService : ICouponService
    {
        public Task<decimal> ApplyDiscountAsync(string code, decimal totalAmount)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(CreateCouponDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetActiveCouponDto>> GetActiveCouponsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<GetAllCouponDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetCouponByIdDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsValidCouponAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, UpdateCouponDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
