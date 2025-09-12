using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Address.Request;
using TechLink.Application.Dtos.User.Request;
using TechLink.Application.Dtos.User.Response;

namespace TechLink.Application.Contracts
{
    public interface IUserService
    {
        Task<GetUserByIdDto> GetByIdAsync(int id);
        Task<GetUserByEmailDto> GetByEmailAsync(string email);
        Task<List<GetAllUserDto>> GetAllAsync(int pageNumber, int pageSize);
        Task<int> RegisterUserAsync(RegisterUserDto dto);
        Task UpdateUserAsync(int id, UpdateUserDto dto);
        Task DeleteUserAsync(int id);
        Task<bool> ValidateUserCredentialsAsync(string email, string password);
        Task ChangePasswordAsync(int userId, string currentPassword, string newPassword);
        Task ResetPasswordAsync(string email);
        Task AssignRoleAsync(int userId, int roleId);
        Task<GetUserRoleDto> GetUserRoleAsync(int userId);
        Task<List<GetUserAddressDto>> GetUserAddressesAsync(int userId);
        Task AddAddressAsync(int userId, CreateAddressDto dto);
        Task UpdateAddressAsync(int addressId, UpdateAddressDto dto);
        Task DeleteAddressAsync(int addressId);
        Task<List<GetUserNotificationDto>> GetUserNotificationsAsync(int userId, bool onlyUnread = false);
        Task MarkNotificationAsReadAsync(int notificationId);
        Task<int> GetUnreadNotificationsCountAsync(int userId);
        Task<DateOnly> GetLastLoginAsync(int userId);
        Task UpdateLastLoginAsync(int userId, DateTime loginTime);
        Task EnableTwoFactorAuthenticationAsync(int userId);
        Task DisableTwoFactorAuthenticationAsync(int userId);
    }
}
