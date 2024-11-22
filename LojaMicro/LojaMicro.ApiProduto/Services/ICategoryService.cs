using LojaMicro.ApiProduto.DTOs;
using LojaMicro.ApiProduto.Models;

namespace LojaMicro.ApiProduto.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();

        Task<IEnumerable<CategoryDTO>> GetCategoriesProducts();

        Task<CategoryDTO> GetCategoryById(int id);

        Task AddCategory(CategoryDTO categoryDto);

        Task UpdateCategory(CategoryDTO categoryDto);

        Task RemoveCategory(int id);
    }
}