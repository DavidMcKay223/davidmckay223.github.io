using MyApp.Application.DTOs.ECommerce;

namespace MyApp.Application.Interfaces.ECommerce
{
    public interface IFakeStoreUseCases
    {
        Task<List<ProductDto?>> GetProductsAsync();
    }
}
