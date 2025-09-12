using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Cart.Request;
using TechLink.Application.Dtos.Cart.Response;

namespace TechLink.Application.Contracts
{
    public interface ICartService
    {
        Task<GetCartByIdDto> GetCartByIdAsync(int cartId);
        Task<GetCartByUserIdDto> GetCartByUserIdAsync(int userId);
        Task<bool> CartExistsForUserAsync(int userId);
        Task CreateCartForUserAsync(int userId);
        Task DeleteCartAsync(int cartId);
        Task AddItemAsync(int cartId, AddCartItemDto newItem);
        Task RemoveItemAsync(int cartId, int productId);
        Task UpdateItemQuantityAsync(int cartId, int productId, int newQuantity);
        Task<List<GetItemsCartDto>> GetItemsAsync(int cartId);
        Task<GetItemDto> GetItemAsync(int cartId, int productId);
        Task IncreaseItemQuantityAsync(int cartId, int productId, int amount);
        Task DecreaseItemQuantityAsync(int cartId, int productId, int amount);
        Task ClearCartAsync(int cartId);
        Task ApplyCouponAsync(int cartId, string couponCode);
        Task RemoveCouponAsync(int cartId);
        Task<decimal> GetTotalAsync(int cartId);
        Task<decimal> GetTotalWithDiscountAsync(int cartId);
    }
}
