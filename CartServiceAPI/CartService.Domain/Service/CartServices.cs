﻿
using CartService.Domain.Interfaces;
using CartService.Domain.Models;
using System.Threading.Tasks;

namespace CartService.Domain.Service
{
    public class CartServices : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartServices(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<Cart> GetCartByUserIdAsync(string userId)
        {
            var cart = await _cartRepository.GetCartByUserIdAsync(userId);
            return cart;
        }

        public async Task<int> AddToCartAsync(CartItem cartItem)
        {
            await _cartRepository.AddToCartAsync(cartItem);
            return cartItem.Id;
        }

        public async Task UpdateCartItemAsync(CartItem cartItem)
        {
            await _cartRepository.UpdateCartItemAsync(cartItem);
        }

        public async Task RemoveFromCartAsync(int cartItemId)
        {
            await _cartRepository.RemoveFromCartAsync(cartItemId);
        }

    }
}
