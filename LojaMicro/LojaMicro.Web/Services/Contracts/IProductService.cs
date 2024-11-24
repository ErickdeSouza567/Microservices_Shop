using LojaMicro.Web.Models;

namespace LojaMicro.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllProducts();

        Task<ProductViewModel> FindProductsById(int id);

        Task<ProductViewModel> CreateProduct(ProductViewModel productVM);

        Task<ProductViewModel> UpdateProduct(ProductViewModel productVM);

        Task<bool> DeleteProductById(int id);
    }
}
