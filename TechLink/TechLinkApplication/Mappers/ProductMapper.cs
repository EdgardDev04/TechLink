using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Product.Request;
using TechLink.Application.Dtos.Product.Response;
using TechLink.Domain.Entities;

namespace TechLink.Application.Mappers
{
    public static class ProductMapper
    {
        public static Product ToEntity(CreateProductDto dto)
        {
            return new Product
            {
               // Id = dto.Id, // o manejarlo en la capa de servicio si corresponde
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
               // Category = dto.Category
            };
        }

        public static GetAllProductDto ToGetAllDto(Product product)
        {
            return new GetAllProductDto
            {
               // Id = product.Id,
                Name = product.Name,
               // Price = product.Price
            };
        }

        public static GetProductByIdDto ToGetByIdDto(Product product)
        {
            return new GetProductByIdDto
            {
             //   Id = product.Id,
                Name = product.Name,
             //   Description = product.Description,
             //  Price = product.Price,
             //   Category = product.Category
            };
        }
    }
}
