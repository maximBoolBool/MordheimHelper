using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SharedServices.Extensions;

public static class DbContextExtension
{
    public static void ApplyMigrates<TDatabase>(this IServiceCollection serviceCollection)
        where TDatabase : DbContext { }
}