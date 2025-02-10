using MyApp.Domain.Abstractions.ECommerce;
using MyApp.Domain.Entities.ECommerce;
using MyApp.Infrastructure.ExternalServices.ECommerce.DTO;
using System.Net.Http.Json;

namespace MyApp.Infrastructure.ExternalServices.ECommerce
{
    public class FakeStoreService : IFakeStoreClient
    {
        private readonly HttpClient _httpClient;

        public FakeStoreService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product?>> GetProductsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ProductDto>>($"/products");
            //var response = await _httpClient.GetFromJsonAsync<Root>($"?{searchProviderCriteria.GetSearchParameter()}");

            if (response != null)
            {
                var products = response.Select(ParseProduct).ToList();
                return products;
            }

            return [];
        }

        private static Product? ParseProduct(ProductDto dto)
        {
            if (dto == null) return null;

            var product = new Product()
            {
                category = dto.category,
                description = dto.description,
                id = dto.id,
                image = dto.image,
                price = dto.price,
                title = dto.title,
                rating = new Rating()
                {
                    count = dto.rating?.count ?? 0,
                    rate = dto.rating?.rate ?? 0
                }
            };

            return product;
        }
    }
}
