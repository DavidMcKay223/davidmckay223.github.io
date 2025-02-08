using AutoMapper;
using MyApp.Application.DTOs.NPI;
using MyApp.Domain.Entities.NPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Mappings.NPI
{
    public class ProviderProfile : Profile
    {
        public ProviderProfile()
        {
            CreateMap<ProviderDto, Provider>()
                .ReverseMap();

            CreateMap<IdentifierDto, Identifier>()
                .ReverseMap();

            CreateMap<EndpointDto, Endpoint>()
                .ReverseMap();
        }
    }
}
