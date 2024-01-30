using Microsoft.Extensions.DependencyInjection;

namespace SharedServices.Repositories.Impl;

public abstract class BaseDbWorkerFactory<TDatabase> : IDbWorkerFactory<TDatabase>
    where TDatabase : IDatabaseWorker
{
    private readonly IServiceScope _scopeFactory;

    protected BaseDbWorkerFactory(IServiceScope scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    public TDatabase? CreateScopeDatabase()
    {
        return _scopeFactory.ServiceProvider.GetService<TDatabase>();
    }
}