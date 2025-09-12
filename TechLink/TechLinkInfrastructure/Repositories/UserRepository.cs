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
    public class UserRepository : IUserRepository
    {
        private readonly TechLinkDbContext _context;

        public UserRepository (TechLinkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User entity)
        {
            _context.User.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task<User> AuthenticateAsync(string email, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                _context.User.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public Task<bool> ExistsByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            var emailuser = await _context.User.FirstOrDefaultAsync(u => u.Email == email);
            return emailuser;
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            var userExist = await _context.User.FirstOrDefaultAsync(u => u.Id == id);
            return userExist;
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            var usernameExist = await _context.User.FirstOrDefaultAsync(u => u.UserName == username);

            return usernameExist;
        }

        public Task<User> GetByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserWithAddressesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserWithRolesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(User entity)
        {
            _context.User.Update(entity);
            await _context.SaveChangesAsync();
        }

        public Task UpdateLastLoginAsync(int id, DateTime lastLogin)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePasswordAsync(int id, string newPasswordHash)
        {
            throw new NotImplementedException();
        }

        Task<List<User>> IUserRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
