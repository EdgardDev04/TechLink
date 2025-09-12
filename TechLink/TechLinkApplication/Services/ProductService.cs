using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Product.Request;
using TechLink.Application.Dtos.Product.Response;
using TechLink.Domain.Entities;
using TechLink.Domain.Enums;
using TechLink.Domain.Interfaces;

namespace TechLink.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService (IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<Product> AddAsync(CreateProductDto dto)
        {
            var product = new Product
            {
                 Name = dto.Name,
                Brand = dto.Brand,
                Image = dto.Image,
                Description = dto.Description,
                State = dto.State,
                Price = dto.Price,
                Stock = dto.Stock,
                CategoryId = dto.CategoryId
    };

            await _repo.AddAsync(product);
            return product;
        }

        public Task<int> CreateAsync(CreateProductDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            if (id < 0)
            {
                return;
            }
            await _repo.DeleteAsync(id);
        }

        public async Task<IEnumerable<GetAllProductDto>> GetAllAsync()
        {
            var productAll = await _repo.GetAllAsync();

            return productAll.Select( p => new GetAllProductDto
            {
                Name = p.Name,
                Description = p.Description,
                Image = p.Image
            }); 
        }

        public Task<List<GetAllProductDto>> GetAllAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetProductByCategoryDto>> GetByCategoryAsync(int categoryId, int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GetProductByCategoryIdDto>> GetByCategoryIdAsync(int categoryId)
        {
            throw new NotImplementedException();

            //return productAll.Select(p => new GetProductByCategoryIdDto
            //{
            //    Name = p.Name,
            //    Description = p.Description,
            //    Image = p.Image
            //});
        }

        public async Task<GetProductByIdDto?> GetByIdAsync(int id)
        {
            var productEntity = await _repo.GetByIdAsync(id);

            if (productEntity == null)
            {
                return null;
            }

            var productDto = new GetProductByIdDto
            {
                 Name = productEntity.Name
            };

            return productDto;
        }

        public Task<List<GetProductsByBrandDto>> GetProductsByBrandAsync(string brand, int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetProductsOnSaleDto>> GetProductsOnSaleAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetTopRatedProductDto>> GetTopRatedProductsAsync(int count)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsInStockAsync(int productId, int requiredQuantity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> SearchAsync(string keyword)
        {
            throw new NotImplementedException();
        }

        public Task<List<SearchProductDto>> SearchAsync(string query, int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SetProductStatusAsync(int productId, StatusProduct status)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, UpdateProductDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStockAsync(int productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
