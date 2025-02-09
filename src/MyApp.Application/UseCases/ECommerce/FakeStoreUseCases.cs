using MyApp.Application.DTOs.ECommerce;
using MyApp.Application.Interfaces.ECommerce;
using MyApp.Domain.Abstractions.ECommerce;
using MyApp.Domain.Abstractions.NPI;
using MyApp.Domain.Entities.ECommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.ECommerce
{
    public class FakeStoreUseCases : IFakeStoreUseCases
    {
        private readonly IFakeStoreClient _fakeStoreClient;

        public FakeStoreUseCases(IFakeStoreClient fakeStoreClient)
        {
            _fakeStoreClient = fakeStoreClient;
        }

        public async Task<List<ProductDto?>> GetProductsAsync()
        {
            return (await _fakeStoreClient.GetProductsAsync()).Select(ParseProduct!).ToList();
        }

        private static ProductDto? ParseProduct(Product item)
        {
            if (item == null) return null;

            var product = new ProductDto()
            {
                category = item.category,
                description = item.description,
                id = item.id,
                image = item.image,
                price = item.price,
                title = item.title,
                rating = new RatingDto()
                {
                    count = item.rating?.count ?? 0,
                    rate = item.rating?.rate ?? 0
                }
            };

            return product;
        }
    }
}
