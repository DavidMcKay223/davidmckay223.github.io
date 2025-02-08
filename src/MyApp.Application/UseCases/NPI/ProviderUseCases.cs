using MyApp.Application.DTOs.NPI;
using MyApp.Application.Interfaces.NPI;
using MyApp.Domain.Abstractions.NPI;
using MyApp.Domain.Specifications.NPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.NPI
{
    public class ProviderUseCases : IProviderUseCases
    {
        private readonly INpiRegistryClient _npiRegistryClient;
        
        public ProviderUseCases(INpiRegistryClient npiRegistryClient)
        {
            _npiRegistryClient = npiRegistryClient;
        }

        public async Task<List<ProviderDto>?> GetProvidersAsync(SearchProviderCriteria dto)
        {
            //return _mapper.Map<List<ProviderDto>?>(await _npiRegistryClient.GetProvidersAsync(dto));
            return [];
        }
    }
}
