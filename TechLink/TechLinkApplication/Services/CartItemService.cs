using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.CartItem.Request;
using TechLink.Application.Dtos.CartItem.Response;

namespace TechLink.Application.Services
{
    public class CartItemService : ICartItemService
    {
        public Task AddItemAsync(CreateCartItemDto itemDto)
        {
            throw new NotImplementedException();
        }

        public Task DecreaseQuantityAsync(int cartItemId, int amount)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetAllCartItemDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<GetCartItemByCartIdDto>> GetByCartIdAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<GetCartItemById> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetItemSubtotalAsync(int cartItemId)
        {
            throw new NotImplementedException();
        }

        public Task IncreaseQuantityAsync(int cartItemId, int amount)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProductInCartAsync(int cartId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveItemAsync(int cartItemId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(UpdateCartItemDto itemDto)
        {
            throw new NotImplementedException();
        }
    }
}
