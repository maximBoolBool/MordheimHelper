using Microsoft.Extensions.DependencyInjection;
using SharedServices.Repositories.Impl;
using UserEntities.Repositories.Impl;

namespace UserEntities;

public class UserDbWorkerFactory : BaseDbWorkerFactory<UserDbWorker>, IUserDbWorkerFactory
{
    public UserDbWorkerFactory(IServiceScope scopeFactory) : base(scopeFactory) { }
}