using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Base;

namespace TechLink.Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; } = string.Empty;
        public string ImageProfile { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateOnly RegisteredAt { get; set; }
        public DateOnly LastLogin { get; set; }
        public Role Role { get; set; }
        public Address Address { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
