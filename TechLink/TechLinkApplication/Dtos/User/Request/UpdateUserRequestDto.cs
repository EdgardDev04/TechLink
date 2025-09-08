using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLink.Application.Dtos.User.Request
{
    public class UpdateUserRequestDto
    {
        public string UserName { get; set; } = string.Empty;
        public string ImageProfile { get; set; } = string.Empty;
        public int RoleId { get; set; }
    }
}
