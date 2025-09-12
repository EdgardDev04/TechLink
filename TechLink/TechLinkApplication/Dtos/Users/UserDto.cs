using System;
using TechLink.Domain.Entities;

namespace TechLink.Application.Dtos.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string ImageProfile { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateOnly RegisteredAt { get; set; }
        public DateOnly LastLogin { get; set; }
        public List<Address> Addresses { get; set; } 
    }
}
