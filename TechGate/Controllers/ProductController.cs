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

            return View(products);
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
        public  async Task<IActionResult> Delete(int id)
        {
            await _productServices.DeleteProductAsync(id);
            return RedirectToAction("All", "Product");
        }
    }
}
