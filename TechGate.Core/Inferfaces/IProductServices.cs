using TechGate.Core.Models;
using TechGate.Infrastructure.Data.Models;

namespace TechGate.Core.Inferfaces
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductCardViewModel>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int productId);
        Task AddProductAsync(AddProductFormViewModel product);
        Task UpdateProductAsync(AddProductFormViewModel product, int id);
        Task DeleteProductAsync(int productId);
        Task<List<ProductCardViewModel>> GetFilteredProductsAsync(decimal? maxPrice, int? categoryId);
    }
}
