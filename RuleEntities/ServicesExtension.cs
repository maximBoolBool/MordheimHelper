using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RuleEntities.Repositories;
using RuleEntities.Repositories.Impl;

namespace RuleEntities;

/// <summary>
///     
/// </summary>
public static class ServicesExtension
{
    public static void AddRuleRepositories(this IServiceCollection services)
    {
        services.AddDbContext<RuleDbContext>(opt => opt.UseNpgsql(""));

        services.AddScoped<DbContext, RuleDbContext>();
        services.AddScoped<IArmorRepository, ArmorRepository>();
        services.AddScoped<IBandRepository, BandRepository>();
        services.AddScoped<IBandSpecialRuleRepository, BandSpeicalRuleRepository>();
        services.AddScoped<ICloseCombatWeaponRepository, CloseCombatWeaponRepository>();
        services.AddScoped<IRangeWeaponRepository, RangeWeaponRepository>();
        services.AddScoped<IWeaponSpecialRuleRepository, WeaponSpecialRuleRepository>();
        services.AddScoped<IUnitRepository, UnitRepository>();
        services.AddScoped<IRuleDbWorker, RuleDbWorker>();
        services.AddScoped<IRuleDbWorkerFactory, RuleDbWorkerFactory>();
    }
}