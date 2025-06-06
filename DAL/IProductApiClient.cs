using ProductManagement.Models;

namespace ProductManagement.DAL
{
    public interface IProductApiClient
    {
        Task<List<ProductDto>> GetProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
    }
}
