using Microsoft.Extensions.DependencyInjection;
using RuleEntities.Repositories;
using RuleEntities.Repositories.Impl;
using SharedServices.Repositories.Impl;

namespace RuleEntities;

public class RuleDbWorkerFactory : BaseDbWorkerFactory<IRuleDbWorker>, IRuleDbWorkerFactory
{
    public RuleDbWorkerFactory(IServiceScopeFactory scopeFactory) : base(scopeFactory) { }
}