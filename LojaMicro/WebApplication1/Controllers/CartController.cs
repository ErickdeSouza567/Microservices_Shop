﻿using LojaMicro.CartApi.DTOs;
using LojaMicro.CartApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaMicro.CartApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CartController : ControllerBase
{
    private readonly ICartRepository _repository;

    public CartController(ICartRepository repository)
    {
        _repository = repository;
    }

    [HttpGet("getcart/{id}")]
    public async Task<ActionResult<CartDTO>> GetByUserId(string userId)
    {
        var cartDto = await _repository.GetCartByUserIdAsync(userId);
        if (cartDto is null)
        {
            return NotFound();
        }
        else
        {
            return Ok(cartDto);
        }
    }

    [HttpPost("addcart")]
    public async Task<ActionResult<CartDTO>> AddCart(CartDTO cartDto)
    {
        var cart = await _repository.UpdateCartAsync(cartDto);
        if (cart is null)
        {
            return NotFound();
        }
        else
        {
            return Ok(cart);
        }
    }

    [HttpPut("updatecart")]
    public async Task<ActionResult<CartDTO>> UpdateCart(CartDTO cartDto)
    {
        var cart = await _repository.UpdateCartAsync(cartDto);
        if (cart == null)
        { 
            return NotFound();
        }
        else 
        {
            return Ok(cart);
        }
    }

    [HttpDelete("deletecart/{id}")]
    public async Task<ActionResult<bool>> DeleteCart(int id)
    {
        var status = await _repository.DeleteItemCartAsync(id);

        if (!status)
        {
            return BadRequest();
        }
        else
        {
        return Ok(status);
    }
  }
}

