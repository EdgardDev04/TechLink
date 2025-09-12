using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Address.Request;
using TechLink.Application.Dtos.Address.Response;

namespace TechLink.Application.Services
{
    public class AddressService : IAddressService
    {
        public Task<bool> BelongsToUserAsync(int addressId, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(CreateAddressDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetAllAddressDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetAddressById> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetAddressByUserIdDto>> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<GetDefaultAddressDto?> GetDefaultAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task SetAsDefaultAsync(int userId, int addressId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, UpdateAddressDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
