using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface IWishListRepository 
    {
        Task<WishList> GetByIdAsync(int id);
        Task<WishList> GetByUserIdAsync(int userId);
        Task<List<WishList>> GetAllAsync();
        Task AddAsync(WishList wishList);
        Task UpdateAsync(WishList wishList);
        Task DeleteAsync(int id);
        Task<bool> ExistsByIdAsync(int id);
        Task<bool> ExistsByUserIdAsync(int userId);
        Task AddProductToWishListAsync(int wishListId, int productId);
        Task RemoveProductFromWishListAsync(int wishListId, int productId);
        Task<List<Product>> GetProductsByWishListIdAsync(int wishListId);
        Task<bool> IsProductInWishListAsync(int wishListId, int productId);
    }
}