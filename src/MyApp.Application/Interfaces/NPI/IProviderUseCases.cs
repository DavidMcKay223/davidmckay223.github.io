using MyApp.Application.DTOs.NPI;
using MyApp.Domain.Specifications.NPI;

namespace MyApp.Application.Interfaces.NPI
{
    public interface IProviderUseCases
    {
        Task<List<ProviderDto>?> GetProvidersAsync(SearchProviderCriteria dto);
    }
}
