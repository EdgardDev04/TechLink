using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLink.Application.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string email)
            : base($"The user with the email address '{email}' was not found.") { }
    }
}
