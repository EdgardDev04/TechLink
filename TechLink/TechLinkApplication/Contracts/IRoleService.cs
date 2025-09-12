using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Role.Request;
using TechLink.Application.Dtos.Role.Response;

namespace TechLink.Application.Contracts
{
    public interface IRoleService
    {
        Task<List<GetAllRoleDto>> GetAllAsync();
        Task<int> CreateAsync(CreateRoleDto dto);
        Task UpdateAsync(int id, UpdateRoleDto dto);
        Task DeleteAsync(int id);
        Task AssignRoleToUserAsync(int userId, int roleId);
        Task RemoveRoleFromUserAsync(int userId, int roleId);
        Task<List<GetRoleByUserIdDto>> GetRolesByUserIdAsync(int userId);
        Task<bool> UserHasRoleAsync(int userId, string roleName);
        Task<List<GetPermissionByRoleIdDto>> GetPermissionsByRoleIdAsync(int roleId);
        Task AddPermissionToRoleAsync(int roleId, int permissionId);
        Task RemovePermissionFromRoleAsync(int roleId, int permissionId);
    }
}
