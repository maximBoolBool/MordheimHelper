using MongoDB.Driver;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="ICloseCombatWeaponRepository"/>
public class CloseCombatWeaponRepository : 
    MongoDbRepository<CloseCombatWeaponRepository> , ICloseCombatWeaponRepository
{
    public CloseCombatWeaponRepository(IMongoDatabase db) : base(db) { }
}