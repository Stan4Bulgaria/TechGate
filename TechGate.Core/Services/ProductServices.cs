using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TechGate.Core.Inferfaces;
using TechGate.Core.Models;
using TechGate.Data;
using TechGate.Infrastructure.Data;
using TechGate.Infrastructure.Data.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TechGate.Core.Services
{
    public class ProductServices : IProductServices
    {
        private readonly TechGateDbContext _context;
        public ProductServices(TechGateDbContext context, ICategoryServices categoryService)
        {
            _context = context;
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
        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var product = await _context.Products
                .Include(c => c.Category)
                .FirstOrDefaultAsync(p => p.Id == productId);

            return product;
        }
        public async Task AddProductAsync(AddProductFormViewModel model)
        {

            var product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                CategoryId = model.CategoryId,
                ImageUrl = model.ImageUrl,
                AmounInStock = model.AmountInStock
            };

            await _context.Products.AddAsync(product);

            await _context.SaveChangesAsync();
        }
        public async Task DeleteProductAsync(int productId)
        {
            var product = await GetProductByIdAsync(productId);
            _context.Products.Remove(product);
            _context.SaveChangesAsync();
        }

        public async Task Details(int id)
        {
            var product = await GetProductByIdAsync(id);
        }

        public async Task UpdateProductAsync(AddProductFormViewModel model, int id)
        {
            var product = await GetProductByIdAsync(id);


            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;
            product.ImageUrl = model.ImageUrl;
            product.CategoryId = model.CategoryId;
            product.AmounInStock = model.AmountInStock;

            await _context.SaveChangesAsync();
        }

        public async Task<ProductPageViewModel> GetFilteredProductsAsync(decimal? maxPrice, decimal? minPrice, int? categoryId)
        {
            var products = _context.Products.Include(c => c.Category).AsQueryable();

            if (maxPrice.HasValue)
            {
                products = products.Where(p => p.Price <= maxPrice);
            }
            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Price >= minPrice);
            }
            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId);
            }
            var filteredProducts = await products.Select(p => new ProductCardViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                ImageUrl = p.ImageUrl,
                CategoryId = p.Category.Id,

            }).ToListAsync();

            var viewModel = new ProductPageViewModel()
            {
                Products = filteredProducts,
                Categories = await _context.Categories
                  .Select(c => new CategoryViewModel()
                  {
                      Id = c.Id,
                      Name = c.Name
                  })
                  .ToListAsync()

            };
            return viewModel;
        }
    }
}
