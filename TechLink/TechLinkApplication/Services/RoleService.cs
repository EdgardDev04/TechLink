using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Role.Request;
using TechLink.Application.Dtos.Role.Response;

namespace TechLink.Application.Services
{
    public class RoleService : IRoleService
    {
        public Task AddPermissionToRoleAsync(int roleId, int permissionId)
        {
            throw new NotImplementedException();
        }

        public Task AssignRoleToUserAsync(int userId, int roleId)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(CreateRoleDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetAllRoleDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<GetPermissionByRoleIdDto>> GetPermissionsByRoleIdAsync(int roleId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetRoleByUserIdDto>> GetRolesByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task RemovePermissionFromRoleAsync(int roleId, int permissionId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRoleFromUserAsync(int userId, int roleId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, UpdateRoleDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserHasRoleAsync(int userId, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
