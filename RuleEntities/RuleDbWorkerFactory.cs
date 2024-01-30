using Microsoft.Extensions.DependencyInjection;
using RuleEntities.Repositories.Impl;
using SharedServices.Repositories.Impl;

namespace RuleEntities;

public class RuleDbWorkerFactory : BaseDbWorkerFactory<RuleDbWorker>, IRuleDbWorkerFactory
{
    public RuleDbWorkerFactory(IServiceScope scopeFactory) : base(scopeFactory) { }
}