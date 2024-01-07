using Microsoft.Extensions.DependencyInjection;
using RuleEntities.Repositories;
using RuleEntities.Repositories.Impl;

namespace RuleEntities;

/// <summary>
///     
/// </summary>
public static class ServicesExtension
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IArmorRepository, ArmorRepository>();
        services.AddScoped<IBandRepository, BandRepository>();
        services.AddScoped<IBandSpecialRuleRepository, BandSpeicalRuleRepository>();
        services.AddScoped<ICloseCombatWeaponRepository, CloseCombatWeaponRepository>();
        services.AddScoped<IRangeWeaponRepository, RangeWeaponRepository>();
        services.AddScoped<ISpecialRuleRepository, SpecialRuleRepository>();
        services.AddScoped<IUnitRepository, UnitRepository>();
    }
}