using CartService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartService.Domain.Interfaces
{
    class CartRepository : ICartRepository
    {
        public Task AddToCartAsync(CartItem cartItem)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetCartByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromCartAsync(int cartItemId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCartItemAsync(CartItem cartItem)
        {
            throw new NotImplementedException();
        }
    }
}
