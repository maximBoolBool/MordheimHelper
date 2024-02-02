using Microsoft.Extensions.DependencyInjection;
using SharedServices.Repositories.Impl;
using UserEntities.Repositories;
using UserEntities.Repositories.Impl;

namespace UserEntities;

public class UserDbWorkerFactory : BaseDbWorkerFactory<UserDbWorker>, IUserDbWorkerFactory
{
    public UserDbWorkerFactory(IServiceScopeFactory scopeFactory) : base(scopeFactory) { }
}