using Microsoft.EntityFrameworkCore;
using TechGate.Core.Inferfaces;
using TechGate.Core.Models.Product;
using TechGate.Data;
using TechGate.Infrastructure.Data.Models;

namespace TechGate.Core.Services
{
    public class ProductServices : IProductServices
    {
        private readonly TechGateDbContext _context;
        public ProductServices(TechGateDbContext context)
        {
            _context = context;
        }
        public Task AddProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductCardViewModel>> GetAllProductsAsync()
        {
            try
            {
                var products = await _context.Products
                    .Select(p => new ProductCardViewModel
                    {
                        Id = p.Id,
                        Name = p.Name ?? "No Name",
                        Price = p.Price,
                        ImageUrl = p.ImageUrl ?? "https://www.tiffincurry.ca/wp-content/uploads/2021/02/default-product.png",
                    })
                    .ToListAsync();

                return products;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving products.", ex);
            }
        }

        public Task<Product> GetProductByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
