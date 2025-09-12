
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Address.Request;
using TechLink.Application.Dtos.User;
using TechLink.Application.Dtos.User.Request;
using TechLink.Application.Dtos.User.Response;
using TechLink.Domain.Interfaces;

namespace TechLink.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public Task AddAddressAsync(int userId, CreateAddressDto dto)
        {
            throw new NotImplementedException();
        }

        public Task AssignRoleAsync(int userId, int roleId)
        {
            throw new NotImplementedException();
        }

        public Task ChangePasswordAsync(int userId, string currentPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAddressAsync(int addressId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DisableTwoFactorAuthenticationAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task EnableTwoFactorAuthenticationAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetAllUserDto>> GetAllAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserByEmailDto> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserByIdDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DateOnly> GetLastLoginAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetUnreadNotificationsCountAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetUserAddressDto>> GetUserAddressesAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetUserNotificationDto>> GetUserNotificationsAsync(int userId, bool onlyUnread = false)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserRoleDto> GetUserRoleAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task MarkNotificationAsReadAsync(int notificationId)
        {
            throw new NotImplementedException();
        }

        public Task<int> RegisterUserAsync(RegisterUserDto dto)
        {
            throw new NotImplementedException();
        }

        public Task ResetPasswordAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAddressAsync(int addressId, UpdateAddressDto dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLastLoginAsync(int userId, DateTime loginTime)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(int id, UpdateUserDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateUserCredentialsAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
