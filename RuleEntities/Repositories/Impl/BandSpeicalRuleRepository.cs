using MongoDB.Driver;
using RuleEntities.Entities;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IBandSpecialRuleRepository"/>
public class BandSpeicalRuleRepository : MongoDbRepository<BandSpecialRuleEntity> , IBandSpecialRuleRepository
{
    public BandSpeicalRuleRepository(IMongoDatabase db) : base(db) { }
}