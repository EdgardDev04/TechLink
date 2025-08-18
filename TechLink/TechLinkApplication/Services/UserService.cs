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
    public class UserService 
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task AddAsync(UserDTO dto)
        {
            var user = new User
            {
                UserName = dto.UserName,
                ImageProfile = dto.ImageProfile,
                Email = dto.Email,
                Password = dto.Password,
                RegisteredAt = DateTime.UtcNow,
                LastLogin = DateTime.UtcNow,
                RoleId = dto.RoleId,
                Role = dto.Role,
                Addresses = dto.Addresses
            };

            await _repo.AddAsync(user);
        }
        
        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _repo.GetByEmailAsync(email);
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            var getbyusername= await _repo.GetByUsernameAsync(username);

            if (getbyusername != null)
            {
                return null;
            }

            return getbyusername;
        }

        public async Task UpdateAsync(UserDTO dto)
        {
            var user = new User
            {
                UserName = dto.UserName,
                ImageProfile = dto.ImageProfile,
            };

            await _repo.UpdateAsync(user);
        }
    }
}
