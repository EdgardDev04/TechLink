using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Domain.Entities;

namespace TechLink.Domain.Interfaces
{
    public interface IReviewRepository 
    {
        Task<Review> GetByIdAsync(int id);
        Task<List<Review>> GetAllAsync();
        Task<List<Review>> GetByProductIdAsync(int productId);
        Task<List<Review>> GetByUserIdAsync(int userId);
        Task<List<Review>> GetByProductAndRatingAsync(int productId, int rating);
        Task AddAsync(Review review);
        Task UpdateAsync(Review review);
        Task DeleteAsync(int id);
        Task<double> GetAverageRatingForProductAsync(int productId);
        Task<int> GetReviewCountForProductAsync(int productId);
        Task<bool> UserHasReviewedProductAsync(int userId, int productId);
    }
}