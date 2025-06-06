using ProductManagement.Models;

namespace ProductManagement.DAL
{
    public class ProductApiClient : IProductApiClient
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ProductDto>>("https://api.escuelajs.co/api/v1/products");
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<ProductDto>($"https://api.escuelajs.co/api/v1/products/{id}");
        }
    }
}
