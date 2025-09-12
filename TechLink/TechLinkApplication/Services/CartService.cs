using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Cart.Request;
using TechLink.Application.Dtos.Cart.Response;
using TechLink.Domain.Interfaces;

namespace TechLink.Application.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _repo;

        public CartService(ICartRepository repo)
        {
            _repo = repo;
        }

        public Task AddItemAsync(int cartId, AddCartItemDto newItem)
        {
            throw new NotImplementedException();
        }

        public Task ApplyCouponAsync(int cartId, string couponCode)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CartExistsForUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task ClearCartAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task CreateCartForUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task DecreaseItemQuantityAsync(int cartId, int productId, int amount)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCartAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<GetCartByIdDto> GetCartByIdAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<GetCartByUserIdDto> GetCartByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<GetItemDto> GetItemAsync(int cartId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetItemsCartDto>> GetItemsAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetTotalAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetTotalWithDiscountAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task IncreaseItemQuantityAsync(int cartId, int productId, int amount)
        {
            throw new NotImplementedException();
        }

        public Task RemoveCouponAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveItemAsync(int cartId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemQuantityAsync(int cartId, int productId, int newQuantity)
        {
            throw new NotImplementedException();
        }
    }
}
