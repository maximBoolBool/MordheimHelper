using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserEntities.Repositories;
using UserEntities.Repositories.Impl;

namespace UserEntities;

public static class ServicesExtension
{
    public static void AddUserRepositories(this IServiceCollection services )
    {
        services.AddScoped<DbContext, UserDbContext>();
        services.AddScoped<IBandRepository, BandRepository>();
        services.AddScoped<IUnitRepository, UnitRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserDbWorker, UserDbWorker>();
        services.AddScoped<IUserDbWorkerFactory, UserDbWorkerFactory>();
    }
}