using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.DTOs;
using TechLink.Domain.Entities;
using TechLink.Domain.Interfaces;

namespace TechLink.Application.Services
{
    public class ShippingService 
    {
        private readonly IShippingRepository _repo;

        public ShippingService(IShippingRepository repo)
        {
            _repo = repo;
        }

        public async Task AddAsync(ShippingDTO dto)
        {
            var shipping = new Shipping();

            await _repo.AddAsync(shipping);
        }

        public Task DeleteAsync(ShippingDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ShippingDTO>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<ShippingDTO?> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task<ShippingDTO?> GetByTrackingNumberAsync(string trackingNumber)
        {
            return await _repo.GetByTrackingNumberAsync(trackingNumber);
        }

        public Task UpdateAsync(ShippingDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
