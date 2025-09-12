using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Review.Request;
using TechLink.Application.Dtos.Review.Response;

namespace TechLink.Application.Services
{
    public class ReviewService : IReviewService
    {
        public Task ApproveReviewAsync(int reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(CreateReviewDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<double> GetAverageRatingByProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<GetReviewByIdDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetReviewByProductIdDto>> GetByProductIdAsync(int productId, int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetReviewByProductUserIdDto>> GetByUserIdAsync(int userId, int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetReviewCountByProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetTopReviewsByProductDto>> GetTopReviewsByProductAsync(int productId, int topCount)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasUserReviewedProductAsync(int userId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task RejectReviewAsync(int reviewId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, UpdateReviewDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
