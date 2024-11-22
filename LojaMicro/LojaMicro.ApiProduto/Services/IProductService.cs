using LojaMicro.ApiProduto.DTOs;
using LojaMicro.ApiProduto.Models;

namespace LojaMicro.ApiProduto.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProductById(int id);
        Task AddProduct(ProductDTO productDto);
        Task UpdateProduct(ProductDTO productDto);
        Task RemoveProduct(int id);
    }

}