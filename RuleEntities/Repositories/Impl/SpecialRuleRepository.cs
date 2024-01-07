using MongoDB.Driver;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="ISpecialRuleRepository"/>
public class SpecialRuleRepository : MongoDbRepository<SpecialRuleRepository>, ISpecialRuleRepository
{
    public SpecialRuleRepository(IMongoDatabase db) : base(db) { }
}