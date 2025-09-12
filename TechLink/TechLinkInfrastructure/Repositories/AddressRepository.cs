using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;
using TechLink.Domain.Interfaces;
using TechLink.Infrastructure.Data;

namespace TechLink.Infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly TechLinkDbContext _context;
        public AddressRepository(TechLinkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Address entity)
        {
            _context.Address.Add(entity);
            await _context.SaveChangesAsync();
        }

        

        public async Task DeleteAsync(int id)
        {
            var address = await _context.Address.FindAsync(id);

            if (address != null)
            {
                _context.Address.Remove(address);
                await _context.SaveChangesAsync();
            }
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Address>> GetAddressesByUserIdAsync(int userId)
        {
            var userExists = await _context.User.AnyAsync(u => u.Id == userId);
            if (!userExists)
            {
                throw new Exception("User does not exist");
            }

            return await _context.Address.Where(a => a.UserId == userId).ToListAsync();
        }

        public async Task<List<Address>> GetAllAsync()
        {
            return await _context.Address.ToListAsync();
        }

        public Task<Address?> GetByIdAsync(int id)
        {
            var addressExist = _context.Address.FirstOrDefaultAsync(u => u.Id == id);

            if (addressExist == null)
            {
                throw new KeyNotFoundException($"Address with ID {id} was not found.");
            }

            return addressExist;
        }

        public Task<List<Address>> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(int id, Address entity)
        {
            var address = await _context.Address.FirstOrDefaultAsync(u => u.Id == id);

            if (address == null)
            {
                throw new KeyNotFoundException($"Address with ID {id} was not found.");
            }

            address.Street = entity.Street;
            address.City = entity.City;
            address.StateOrProvince = entity.StateOrProvince;
            address.PostalCode = entity.PostalCode;
            address.Country = entity.Country;

            await _context.SaveChangesAsync();
        }

        public Task UpdateAsync(Address address)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePartialAsync(int id, Action<Address> updateAction)
        {
            throw new NotImplementedException();
        }
    }
}
