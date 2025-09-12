using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Address.Request;
using TechLink.Application.Dtos.Address.Response;

namespace TechLink.Application.Contracts
{
    public interface IAddressService
    {
        Task<GetAddressById> GetByIdAsync(int id);
        Task<List<GetAllAddressDto>> GetAllAsync();
        Task<List<GetAddressByUserIdDto>> GetByUserIdAsync(int userId);
        Task<int> CreateAsync(CreateAddressDto dto);
        Task UpdateAsync(int id, UpdateAddressDto dto);
        Task DeleteAsync(int id);
        Task<bool> BelongsToUserAsync(int addressId, int userId);
        Task SetAsDefaultAsync(int userId, int addressId);
        Task<GetDefaultAddressDto?> GetDefaultAsync(int userId);
    }

}
