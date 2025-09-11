using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Product.Request;
using TechLink.Application.Dtos.Product.Response;
using TechLink.Application.Dtos.User;
using TechLink.Application.DTOs;
using TechLink.Domain.Entities;
using TechLink.Domain.Enums;
using TechLink.Domain.Interfaces;

namespace TechLink.Application.Services
{
    public class ProductService 
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

        public async Task<IEnumerable<GetProductByCategoryIdDto>> GetByCategoryIdAsync(int categoryId)
        {
            var productAll = await _repo.GetByCategoryIdAsync(categoryId);

            return productAll.Select(p => new GetProductByCategoryIdDto
            {
                Name = p.Name,
                Description = p.Description,
                Image = p.Image
            });
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

        public async Task<IEnumerable<Product>> SearchAsync(string keyword)
        {
            var product = await _repo.SearchAsync(keyword);

            var search = new SearchDto
            {
                Name = product.Name
            };

            return search;
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
