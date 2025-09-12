using TechLink.Application.Dtos.User;
using TechLink.Application.Dtos.User.Request;
using TechLink.Domain.Entities;

namespace TechLink.Application.Mappers
{
    public static class UserMapper
    {
        public static UserDto ToUserDto(this User userModel)
        {
            return new UserDto
            {
                Id = userModel.Id,
                UserName = userModel.UserName,
                ImageProfile = userModel.ImageProfile,
                Email = userModel.Email,
                Password = userModel.Password,
                RegisteredAt = userModel.RegisteredAt,
                Addresses = userModel.Addresses.Select(c => c.ToAddressDto()).ToList()
            };
        }

        public static UserDto ToUserEntity(this UserDto dto)
        {
            return new UserDto
            {
                Id = dto.Id,
                UserName = dto.UserName,
                ImageProfile = dto.ImageProfile,
                Email = dto.Email,
                Password = dto.Password,
                RegisteredAt = dto.RegisteredAt
            };
        }

        public static User ToUserFromCreatedDto(this CreateUserDto dto)
        {
            return new User
            {
                UserName = dto.UserName,
                ImageProfile = dto.ImageProfile,
                Email = dto.Email,
                Password = dto.Password,
                RegisteredAt = dto.RegisteredAt
            };
        }
    }
}
