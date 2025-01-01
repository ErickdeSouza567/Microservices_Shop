using LojaMicro.Web.Models;
using LojaMicro.Web.Services.Contracts;
using System.Text.Json;

namespace LojaMicro.Web.Services;

public class CartService : ICartService
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly JsonSerializerOptions? _options;
    private const string apiEndpoint = "/api/cart";
    private CartViewModel cartVM = new CartViewModel();

    public CartService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public Task<CartViewModel> GetCartByUserIdAsync(string userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<CartViewModel> AddItemToCartAsync(CartViewModel cartVM, string token)
    {
        throw new NotImplementedException();
    }

    public Task<CartViewModel> UpdateCartAsync(CartViewModel cartVM, string token)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveItemFromCartAsync(int cartId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ApplyCouponAsync(CartViewModel cartVM, string couponCode, string token)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveCouponAsync(string userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ClearCartAsync(string userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<CartViewModel> CheckouAsync(CartHeaderViewModel cartHeader, string token)
    {
        throw new NotImplementedException();
    }
}
