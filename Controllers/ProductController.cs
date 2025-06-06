using Microsoft.AspNetCore.Mvc;
using ProductManagement.BLL;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ActionResult> Index(string productId)
        {
            if (string.IsNullOrWhiteSpace(productId) || !int.TryParse(productId, out int id))
            {
                var productos = await _productService.GetAllProducts();
                return View(productos);
            }
            else
            {
                var producto = await _productService.GetProductById(id);
                return View(new List<Product> { producto });
            }
        }
    }
}
