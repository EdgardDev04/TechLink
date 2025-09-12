using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Product.Request;
using TechLink.Application.Dtos.Product.Response;
using TechLink.Domain.Enums;

namespace TechLink.Application.Contracts
{
    public interface IProductService
    {
        Task<GetProductByIdDto> GetByIdAsync(int id);
        Task<List<GetAllProductDto>> GetAllAsync(int pageNumber, int pageSize);
        Task<List<GetProductByCategoryDto>> GetByCategoryAsync(int categoryId, int pageNumber, int pageSize);
        Task<List<SearchProductDto>> SearchAsync(string query, int pageNumber, int pageSize);
        Task<int> CreateAsync(CreateProductDto dto);
        Task UpdateAsync(int id, UpdateProductDto dto);
        Task DeleteAsync(int id);
        Task<bool> UpdateStockAsync(int productId, int quantity);
        Task<bool> IsInStockAsync(int productId, int requiredQuantity);
        Task<List<GetTopRatedProductDto>> GetTopRatedProductsAsync(int count);
        Task<List<GetProductsOnSaleDto>> GetProductsOnSaleAsync(int pageNumber, int pageSize);
        Task<List<GetProductsByBrandDto>> GetProductsByBrandAsync(string brand, int pageNumber, int pageSize);
        Task<bool> SetProductStatusAsync(int productId, StatusProduct status);
    }
}
