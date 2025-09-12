using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.WishList.Response;

namespace TechLink.Application.Contracts
{
    public interface IWishListService
    {
        Task<GetWishListByUserId> GetByUserIdAsync(int userId);
        Task<List<GetProductInWishListDto>> GetProductsInWishListAsync(int userId);

        Task AddProductToWishListAsync(int userId, int productId);
        Task RemoveProductFromWishListAsync(int userId, int productId);

        Task ClearWishListAsync(int userId);

        Task<bool> IsProductInWishListAsync(int userId, int productId);

        Task<int> GetWishListCountAsync(int userId);
    }
}
