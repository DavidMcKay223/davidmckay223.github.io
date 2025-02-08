using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyApp.Application.Interfaces.NPI;
using MyApp.Application.UseCases.NPI;
using MyApp.Domain.Abstractions.NPI;
using MyApp.Infrastructure.ExternalServices.NPI;
using MyApp.Shared.Interfaces;
using MyApp.Shared.Services;
using MyApp.Web;
using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using MyApp.Application.Interfaces.Food;
using MyApp.Application.UseCases.Food;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Services:
builder.Services.AddScoped<IStateService, StateService>();
builder.Services.AddScoped<IProviderUseCases, ProviderUseCases>();
builder.Services.AddScoped<INutritionCalculatorService, NutritionCalculatorService>();

// Needs Server Proxy: (Out of Scope)
builder.Services.AddScoped<INpiRegistryClient, NpiRegistryService>(sp => new NpiRegistryService(new HttpClient { BaseAddress = new Uri("https://npiregistry.cms.hhs.gov/api/") }));

await builder.Build().RunAsync();
