using MyApp.Domain.Entities.ECommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Abstractions.ECommerce
{
    public interface IFakeStoreClient
    {
        Task<List<Product?>> GetProductsAsync();
    }
}
