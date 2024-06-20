using CartService.API.Domain.Models;
using CartService.API.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartService.API.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<Cart>> GetCartByUserId(string userId)
        {
            var cart = await _cartService.GetCartByUserIdAsync(userId);
            if (cart == null)
            {
                return NotFound();
            }
            return Ok(cart);
        }

        [HttpPost]
        public async Task<ActionResult> AddToCart(CartItem cartItem)
        {
            await _cartService.AddToCartAsync(cartItem);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCartItem(CartItem cartItem)
        {
            await _cartService.UpdateCartItemAsync(cartItem);
            return Ok();
        }

        [HttpDelete("{cartItemId}")]
        public async Task<ActionResult> RemoveFromCart(int cartItemId)
        {
            await _cartService.RemoveFromCartAsync(cartItemId);
            return Ok();
        }
    }
}
