using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TechLink.Application.Dtos.User;
using TechLink.Application.Dtos.User.Request;
using TechLink.Application.Dtos.User.Response;
using TechLink.Domain.Entities;
using TechLink.Domain.Interfaces;

namespace TechLink.Application.Services
{
    public class UserService 
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateUserDto dto)
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
        
        public async Task<GetUserByEmailResponseDto> GetByEmailAsync(string email)
        {
            var user = await _repo.GetByEmailAsync(email);

            if (user == null)
            {
                throw new Exception("User does not exist");
            }

            return _mapper.Map<GetUserByEmailResponseDto>(user);

        }

        public async Task<GetUserByIdResponseDto?> GetByIdAsync(int id)
        {
            var user = await _repo.GetByIdAsync(id);

            if (user == null)
            {
                throw new Exception("User does not exist");
            }

            return new GetUserByIdResponseDto
            {
                UserName = user.UserName
            };
        }

        public async Task<GetUserByUsernameResponseDto?> GetByUsernameAsync(string username)
        {
            var user= await _repo.GetByUsernameAsync(username);

            if (user == null)
            {
                return null;
            }

            return new GetUserByUsernameResponseDto
            {
                Username = user.UserName
            };
        }

        public async Task UpdateAsync(UpdateUserDto dto)
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
