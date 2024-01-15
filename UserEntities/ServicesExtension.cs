using Microsoft.Extensions.DependencyInjection;
using UserEntities.Repositories;
using UserEntities.Repositories.Impl;

namespace UserEntities;

public class ServicesExtension
{
    public static void AddRepositories(ServiceCollection services )
    {
        services.AddScoped<IBandRepository, BandRepository>();
        services.AddScoped<IUnitRepository, UnitRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}