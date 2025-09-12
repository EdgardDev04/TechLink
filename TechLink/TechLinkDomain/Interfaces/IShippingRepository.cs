using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface IShippingRepository
    {
        Task<Shipping> GetByIdAsync(int id);
        Task<List<Shipping>> GetAllAsync();
        Task<List<Shipping>> GetByCarrierAsync(string carrier);
        Task<List<Shipping>> GetByEstimatedDeliveryDateAsync(DateTime date);
        Task<List<Shipping>> GetPendingShipmentsAsync();
        Task AddAsync(Shipping shipping);
        Task UpdateAsync(Shipping shipping);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}