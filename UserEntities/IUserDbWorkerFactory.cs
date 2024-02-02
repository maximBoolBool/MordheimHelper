using SharedServices.Repositories;
using UserEntities.Repositories;
using UserEntities.Repositories.Impl;

namespace UserEntities;

public interface IUserDbWorkerFactory : IDbWorkerFactory<UserDbWorker> { }