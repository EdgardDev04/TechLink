using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLink.Application.Dtos.Category.Response;

namespace TechLink.Application.Contracts
{
    public interface ICategoryService
    {
        Task<GetCategoryByIdDto> GetByIdAsync(int id);
        Task<List<GetAllCategoryDto>> GetAllAsync();
        Task<List<SearchCategoryDto>> SearchByNameAsync(string name);
    }
}
