using CartService.Domain.Models;
using System.Threading.Tasks;

namespace CartService.Domain.Interfaces
{
    public interface ICartRepository
    {
        Task<Cart> GetCartByUserIdAsync(string userId);
        Task AddToCartAsync(CartItem cartItem);
        Task UpdateCartItemAsync(CartItem cartItem);
        Task RemoveFromCartAsync(int cartItemId);
    }
}
