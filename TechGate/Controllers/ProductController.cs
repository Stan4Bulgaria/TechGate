using Microsoft.AspNetCore.Mvc;
using TechGate.Core.Inferfaces;
using TechGate.Core.Models;
using TechGate.Core.Services;

namespace TechGate.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;
        private readonly ICategoryServices _categoryServices;

        public ProductController(IProductServices productServices, ICategoryServices categoryServices)
        {
            _productServices = productServices;
            _categoryServices = categoryServices;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {

            var products = await _productServices.GetAllProductsAsync();
            var categories = await _categoryServices.GetAllCategoriesAsync();

            var viewModel = new ProductPageViewModel
            {
                Products = products.ToList(),
                Categories = categories.ToList(),
            };

            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Add()

        {
            var categories = await _categoryServices.GetAllCategoriesAsync();
            var productFormModel = new AddProductFormViewModel()
            {
                Categories = categories
            };

            return View(productFormModel);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddProductFormViewModel model)

        {
            await _productServices.AddProductAsync(model);

            return RedirectToAction("All", "Product");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productServices.GetProductByIdAsync(id);
            var model = new AddProductFormViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                CategoryId = product.CategoryId,
                AmountInStock = product.AmounInStock,
                Categories = await _categoryServices.GetAllCategoriesAsync(),
            };
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(AddProductFormViewModel model, int id)
        {
            await _productServices.UpdateProductAsync(model, id);

            return RedirectToAction("All", "Product");


        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productServices.GetProductByIdAsync(id);

            var model = new ProductDetailsViewModel()
            {
                Id= product.Id,
                Name= product.Name,
                Description= product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Category = product.Category.Name

            };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> FilteredProducts(decimal? maxPrice, decimal? minPrice ,int? categoryId)
        {
            var products = await _productServices.GetFilteredProductsAsync(maxPrice, minPrice,categoryId);

            return View("All", products);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productServices.GetProductByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ProductDeleteViewModel
            {
                Id = product.Id,
                Name = product.Name,
                ImageUrl = product.ImageUrl
            };

            return View(viewModel);
        }
        [HttpPost]
        [ActionName("Delete")]
        public  async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _productServices.DeleteProductAsync(id);
            return RedirectToAction("All", "Product");
        }
    }
}
