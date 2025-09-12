using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface IUserRepository 
    {
        Task<User> GetByIdAsync(int id);
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByUserNameAsync(string userName);
        Task<List<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
        Task<bool> ExistsByIdAsync(int id);
        Task<bool> ExistsByEmailAsync(string email);
        Task<bool> ExistsByUserNameAsync(string userName);
        Task<User> GetUserWithRolesAsync(int id);
        Task<User> GetUserWithAddressesAsync(int id);
        Task<User> AuthenticateAsync(string email, string passwordHash);
        Task UpdateLastLoginAsync(int id, DateTime lastLogin);
        Task UpdatePasswordAsync(int id, string newPasswordHash);
    }
}