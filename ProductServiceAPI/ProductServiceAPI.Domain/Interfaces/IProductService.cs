using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductService.Domain.Services
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);


    }
}