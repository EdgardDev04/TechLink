using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<List<Address>> GetAddressesByUserIdAsync(int userId);
    }
}
