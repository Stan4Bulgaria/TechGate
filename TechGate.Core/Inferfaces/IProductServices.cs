using TechGate.Core.Models.Product;
using TechGate.Infrastructure.Data.Models;

namespace TechGate.Core.Inferfaces
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductCardViewModel>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int productId);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int productId);
    }
}
