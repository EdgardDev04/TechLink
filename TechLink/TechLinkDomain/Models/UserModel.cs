using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Models
{
    public class UserModel
    {
        public string UserName { get; set; } = string.Empty;
        public string ImageProfile { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime RegisteredAt { get; set; }
        public DateTime LastLogin { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
