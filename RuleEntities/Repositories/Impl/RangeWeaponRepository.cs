using MongoDB.Driver;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IRangeWeaponRepository"/>
public class RangeWeaponRepository : MongoDbRepository<RangeWeaponRepository>, IRangeWeaponRepository
{
    public RangeWeaponRepository(IMongoDatabase db) : base(db) { }
}