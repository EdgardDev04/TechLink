using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface IAddressRepository 
    {
        Task<Address> GetByIdAsync(int id);
        Task<List<Address>> GetAllAsync();
        Task<List<Address>> GetByUserIdAsync(int userId);
        Task AddAsync(Address address);
        Task UpdateAsync(Address address);
        Task UpdatePartialAsync(int id, Action<Address> updateAction);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
