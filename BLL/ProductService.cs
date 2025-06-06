using ProductManagement.DAL;
using ProductManagement.Helpers;
using ProductManagement.Models;

namespace ProductManagement.BLL
{
    public class ProductService : IProductService
    {
        private readonly IProductApiClient _apiClient;

        public ProductService(IProductApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var dtos = await _apiClient.GetProductsAsync();
            var products = dtos.Select(ProductMapper.MapFromDto).ToList();

            foreach (var product in products)
            {
                product.Tax = CalcularImpuesto(product.Price);
            }

            return products;
        }

        public async Task<Product> GetProductById(int id)
        {
            var dto = await _apiClient.GetProductByIdAsync(id);
            var product = ProductMapper.MapFromDto(dto);

            product.Tax = CalcularImpuesto(product.Price);
            return product;
        }

        private decimal CalcularImpuesto(decimal precio)
        {
            return precio * 0.19m;
        }
    }
}
