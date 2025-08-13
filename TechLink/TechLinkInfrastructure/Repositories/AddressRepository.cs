using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task DeleteAsync(Address entity)
        {
            _context.Address.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Address>> GetAddressesByUserIdAsync(int userId)
        {
            var userExists = await _context.User.AnyAsync(u => u.Id == userId);
            if (!userExists)
            {
                throw new Exception("User does not exist");
            }

            return await _context.Address.Where(a => a.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Address>> GetAllAsync()
        {
            return await _context.Address.ToListAsync();
        }

        public Task<Address?> GetByIdAsync(int id)
        {
            var addressExist = _context.Address.FirstOrDefaultAsync(u => u.Id == id);

            if (addressExist == null)
            {
                throw new Exception("address does not exist");
            }

            return addressExist;
        }

        public async Task UpdateAsync(Address entity)
        {
            _context.Address.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
