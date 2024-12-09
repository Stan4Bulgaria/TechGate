using Microsoft.AspNetCore.Mvc;
using TechGate.Core.Inferfaces;

namespace TechGate.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        public async Task<IActionResult> All()
        {
            var products = await _productServices.GetAllProductsAsync();

            return View(products);
        }
    }
}
