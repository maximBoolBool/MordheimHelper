using Microsoft.Extensions.DependencyInjection;
using RuleServices.Services;
using RuleServices.Services.Impl;

namespace RuleServices;

public static class ServiceCollectionExtension
{
    public static void AddRuleService(this IServiceCollection services)
    {
        services.AddScoped<IBandService, BandService>();
    }
}