using ProductManagement.Models;

namespace ProductManagement.Helpers
{
    public class ProductMapper
    {
        public static Product MapFromDto(ProductDto dto)
        {
            return new Product
            {
                Id = dto.Id,
                Title = dto.Title,
                Price = dto.Price,
                Description = dto.Description
            };
        }
    }
}
