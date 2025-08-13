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

        public async Task DeleteAsync(User entity)
        {
            _context.User.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.User.ToListAsync();
        }

        public Task<User?> GetByEmailAsync(string email)
        {
            var emailExist = _context.User.FirstOrDefaultAsync(u => u.Email == email);

            if (emailExist == null)
            {
                throw new Exception("User does not exist");
            }
            return emailExist;
        }

        public Task<User?> GetByIdAsync(int id)
        {
            var userExist = _context.User.FirstOrDefaultAsync(u => u.Id == id);

            if (userExist == null)
            {
                throw new Exception("User does not exist");
            }
            return userExist;
        }

        public Task<User?> GetByUsernameAsync(string username)
        {
            var usernameExist = _context.User.FirstOrDefaultAsync(u => u.UserName == username);

            if (usernameExist == null)
            {
                throw new Exception("User does not exist");
            }
            return usernameExist;
        }

        public async Task UpdateAsync(User entity)
        {
            _context.User.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
