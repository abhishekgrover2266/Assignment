using CartService.API.Infrastructure.CartsDbContext;
using CartService.Domain.Interfaces;
using CartService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartService.Infrastructure.Repo
{
    public class CartRepository : ICartRepository
    {
        private readonly CartDbContext _dbContext;

        public CartRepository(CartDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        async Task ICartRepository.AddToCartAsync(CartItem cartItem)
        {
            await _dbContext.CartItems.AddAsync(cartItem);
            await _dbContext.SaveChangesAsync();
        }

        async Task<Cart> ICartRepository.GetCartByUserIdAsync(string userId)
        {
            return await _dbContext.Carts.FindAsync(userId);
        }

        async Task ICartRepository.RemoveFromCartAsync(int cartItemId)
        {
            var cartItem = await _dbContext.CartItems.FindAsync(cartItemId);
            if (cartItem != null)
            {
                _dbContext.CartItems.Remove(cartItem);
                await _dbContext.SaveChangesAsync();
            }
        }

        async Task ICartRepository.UpdateCartItemAsync(CartItem cartItem)
        {
            _dbContext.Entry(cartItem).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
