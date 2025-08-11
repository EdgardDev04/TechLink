using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface IWishListRepository : IRepository<WishList>
    {
        Task<WishList?> GetByUserIdAsync(int userId);
    }
}
