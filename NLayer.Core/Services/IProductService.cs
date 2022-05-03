using NLayer.Core.DTOs;

namespace NLayer.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomeResponseDto<List<ProductWithCategoryDto>>> GetProductsWitCategory();
    }
}
