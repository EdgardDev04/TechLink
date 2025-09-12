using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Review.Request;
using TechLink.Application.Dtos.Review.Response;

namespace TechLink.Application.Contracts
{
    public interface IReviewService
    {
        Task<GetReviewByIdDto> GetByIdAsync(int id);
        Task<List<GetReviewByProductIdDto>> GetByProductIdAsync(int productId, int pageNumber, int pageSize);
        Task<List<GetReviewByProductUserIdDto>> GetByUserIdAsync(int userId, int pageNumber, int pageSize);
        Task<int> CreateAsync(CreateReviewDto dto);
        Task UpdateAsync(int id, UpdateReviewDto dto);
        Task DeleteAsync(int id);
        Task<double> GetAverageRatingByProductAsync(int productId);
        Task<int> GetReviewCountByProductAsync(int productId);
        Task<bool> HasUserReviewedProductAsync(int userId, int productId);
        Task<List<GetTopReviewsByProductDto>> GetTopReviewsByProductAsync(int productId, int topCount);
        Task ApproveReviewAsync(int reviewId);
        Task RejectReviewAsync(int reviewId);
    }
}
