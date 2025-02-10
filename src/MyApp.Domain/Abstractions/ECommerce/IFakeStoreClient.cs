using MyApp.Domain.Entities.ECommerce;

namespace MyApp.Domain.Abstractions.ECommerce
{
    public interface IFakeStoreClient
    {
        Task<List<Product?>> GetProductsAsync();
    }
}
