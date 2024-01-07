using MongoDB.Driver;
using RuleEntities.Entities;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IUnitRepository"/>
public class UnitRepository : MongoDbRepository<UnitEntity>, IUnitRepository
{
    public UnitRepository(IMongoDatabase db) : base(db) { }
}