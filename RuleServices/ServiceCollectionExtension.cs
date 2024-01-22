using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RuleServices.Mappers;
using RuleServices.Services;
using RuleServices.Services.Impl;

namespace RuleServices;

public static class ServiceCollectionExtension
{
    public static void AddRuleService(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(RuleMapperProfile));
        services.AddScoped<IBandService, BandService>();
    }
}