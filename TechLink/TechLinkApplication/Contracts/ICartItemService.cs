using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.CartItem.Request;
using TechLink.Application.Dtos.CartItem.Response;

namespace TechLink.Application.Contracts
{
    public interface ICartItemService
    {
        Task<GetCartItemById> GetByIdAsync(int id);
        Task<List<GetAllCartItemDto>> GetAllAsync();
        Task<List<GetCartItemByCartIdDto>> GetByCartIdAsync(int cartId);
        Task AddItemAsync(CreateCartItemDto itemDto);
        Task UpdateItemAsync(UpdateCartItemDto itemDto);
        Task RemoveItemAsync(int cartItemId);
        Task<bool> IsProductInCartAsync(int cartId, int productId);
        Task IncreaseQuantityAsync(int cartItemId, int amount);
        Task DecreaseQuantityAsync(int cartItemId, int amount);
        Task<decimal> GetItemSubtotalAsync(int cartItemId);
    }
}
