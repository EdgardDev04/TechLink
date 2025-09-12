using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;
using TechLink.Domain.Interfaces;
using TechLink.Infrastructure.Data;

namespace TechLink.Infrastructure.Repositories
{
    public class WishListRepository : IWishListRepository
    {
        private readonly TechLinkDbContext _context;

        public WishListRepository(TechLinkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(WishList entity)
        {
            _context.WishList.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task AddProductToWishListAsync(int wishListId, int productId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var wishlist = await _context.WishList.FindAsync(id);

            if (wishlist != null)
            {
                _context.WishList.Remove(wishlist);
                await _context.SaveChangesAsync();
            }
        }

        public Task<bool> ExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<WishList>> GetAllAsync()
        {
            return await _context.WishList.ToListAsync();
        }

        public Task<WishList?> GetByIdAsync(int id)
        {
            var wishlExist = _context.WishList.FirstOrDefaultAsync(u => u.Id == id);

            if (wishlExist == null)
            {
                throw new Exception("User does not exist");
            }
            return wishlExist;
        }

        public Task<WishList?> GetByUserIdAsync(int userId)
        {
            var wishlExist = _context.WishList.FirstOrDefaultAsync(u => u.UserId == userId);

            if (wishlExist == null)
            {
                throw new Exception("Wishlist is not associated an user");
            }
            return wishlExist;
        }

        public Task<List<Product>> GetProductsByWishListIdAsync(int wishListId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProductInWishListAsync(int wishListId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveProductFromWishListAsync(int wishListId, int productId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(WishList entity)
        {
            _context.WishList.Update(entity);
            await _context.SaveChangesAsync();
        }

        Task<List<WishList>> IWishListRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
