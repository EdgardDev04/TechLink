using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.WishList.Response;

namespace TechLink.Application.Services
{
    public class WishListService : IWishListService
    {
        public Task AddProductToWishListAsync(int userId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task ClearWishListAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<GetWishListByUserId> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetProductInWishListDto>> GetProductsInWishListAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetWishListCountAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProductInWishListAsync(int userId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveProductFromWishListAsync(int userId, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
