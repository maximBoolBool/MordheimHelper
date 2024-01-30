using RuleEntities.Repositories.Impl;
using SharedServices.Repositories;

namespace RuleEntities;

public interface IRuleDbWorkerFactory : IDbWorkerFactory<RuleDbWorker> { }