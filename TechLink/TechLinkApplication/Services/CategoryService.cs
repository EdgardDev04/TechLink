using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Contracts;
using TechLink.Application.Dtos.Category.Response;

namespace TechLink.Application.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<List<GetAllCategoryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetCategoryByIdDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SearchCategoryDto>> SearchByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
