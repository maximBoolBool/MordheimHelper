using Microsoft.Extensions.DependencyInjection;

namespace SharedServices.Repositories.Impl;

public abstract class BaseDbWorkerFactory<TDatabase> : IDbWorkerFactory<TDatabase>
    where TDatabase : IDbWorker
{
    private readonly IServiceScopeFactory _scopeFactory;

    protected BaseDbWorkerFactory(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    public TDatabase CreateScopeDatabase()
    {
        return _scopeFactory.CreateScope().ServiceProvider.GetService<TDatabase>()!;
    }
}