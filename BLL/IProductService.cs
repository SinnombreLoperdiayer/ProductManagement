using ProductManagement.Models;

namespace ProductManagement.BLL
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
    }
}
