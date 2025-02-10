using MyApp.Domain.Entities.NPI;
using MyApp.Domain.Specifications.NPI;

namespace MyApp.Domain.Abstractions.NPI
{
    public interface INpiRegistryClient
    {
        Task<List<Provider?>> GetProvidersAsync(SearchProviderCriteria searchProviderCriteria);
        Task<Provider?> GetProviderByNpiAsync(string npiNumber);
    }
}
