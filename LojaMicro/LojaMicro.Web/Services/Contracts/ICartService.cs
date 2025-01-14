﻿using LojaMicro.Web.Models;

namespace LojaMicro.Web.Services.Contracts
{
    public interface ICartService
    {
        Task<CartViewModel> GetCartByUserIdAsync(string userId, string token);
        Task<CartViewModel> AddItemToCartAsync(CartViewModel cartVM, string token);

        Task<CartViewModel> UpdateCartAsync(CartViewModel cartVM, string token);

        Task<bool> RemoveItemFromCartAsync(int cartId, string token);

        Task<bool> ApplyCouponAsync(CartViewModel cartVM, string couponCode, string token);
        Task<bool> RemoveCouponAsync(string userId, string token);
        Task<bool> ClearCartAsync(string userId, string token);

        Task<CartViewModel> CheckouAsync(CartHeaderViewModel cartHeader, string token);


    }
}
