namespace LojaMicro.Web.Services.Contracts;

using LojaMicro.Web.Models;

public interface ICategoryService
{
    Task<IEnumerable<CategoryViewModel>> GetAllCategories()
}
