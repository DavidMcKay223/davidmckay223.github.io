using MyApp.Application.DTOs.ECommerce;
using MyApp.Application.DTOs.NPI;
using MyApp.Domain.Specifications.NPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Interfaces.ECommerce
{
    public interface IFakeStoreUseCases
    {
        Task<List<ProductDto?>> GetProductsAsync();
    }
}
