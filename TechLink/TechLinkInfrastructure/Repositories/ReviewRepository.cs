using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechLink.Domain.Entities;
using TechLink.Domain.Interfaces;
using TechLink.Infrastructure.Data;

namespace TechLink.Infrastructure.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly TechLinkDbContext _context;

        public ReviewRepository(TechLinkDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Review entity)
        {
            _context.Review.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var review = await _context.Review.FindAsync(id);
            if (review != null)
            {
                _context.Review.Remove(review);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Review>> GetAllAsync()
        {
            return await _context.Review.ToListAsync();
        }

        public Task<Review?> GetByIdAsync(int id)
        {
            var getReview = _context.Review.FirstOrDefaultAsync(u => u.Id == id);

            if (getReview == null)
            {
                throw new Exception("Review does not exist");
            }
            return getReview;
        }

        public async Task<IEnumerable<Review>> GetByProductIdAsync(int productId)
        {
            var getReview = await _context.Review.Where(p => p.ProductId == productId).ToListAsync();

            if (!getReview.Any())
            {
                throw new Exception("");
            }

            return getReview;
        }

        public async Task UpdateAsync(Review entity)
        {
            _context.Review.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
