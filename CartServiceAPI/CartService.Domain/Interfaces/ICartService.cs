using CartService.Domain.Models;
using System.Threading.Tasks;

namespace CartService.Domain.Service
{
    public interface ICartService
    {
        Task<int> AddToCartAsync(CartItem cartItem);
        Task<Cart> GetCartByUserIdAsync(string userId);
        Task RemoveFromCartAsync(int cartItemId);
        Task UpdateCartItemAsync(CartItem cartItem);
    }
}