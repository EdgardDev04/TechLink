using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.User;
using TechLink.Application.Dtos.User.Request;
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

        public async Task AddAsync(CreateUserRequestDto dto)
        {
            var user = new User
            {
                UserName = dto.UserName,
                ImageProfile = dto.ImageProfile,
                Email = dto.Email,
                Password = dto.Password,
                RegisteredAt = DateTime.UtcNow,
                LastLogin = DateTime.UtcNow,
                RoleId = dto.RoleId
            };

            await _repo.AddAsync(user);
        }
        
        public async Task<User?> GetByEmailAsync(string email)
        {
            var user = await _repo.GetByEmailAsync(email);

            if (user == null)
            {
                throw new Exception("User does not exist");
            }

            return user;
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            var user = await _repo.GetByIdAsync(id);

            if (user == null)
            {
                throw new Exception("User does not exist");
            }

            return user;
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            var user= await _repo.GetByUsernameAsync(username);

            if (user == null)
            {
                return null;
            }

            return user;
        }

        public async Task UpdateAsync(UpdateUserRequestDto dto)
        {
            var user = new User
            {
                UserName = dto.UserName,
                ImageProfile = dto.ImageProfile
            };

            await _repo.UpdateAsync(user);
        }
    }
}
