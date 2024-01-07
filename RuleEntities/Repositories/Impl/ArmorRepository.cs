using MongoDB.Driver;
using RuleEntities.Entities;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IArmorRepository"/>
internal class ArmorRepository : MongoDbRepository<ArmorEntity>, IArmorRepository
{
    public ArmorRepository(IMongoDatabase db) : base(db) { }
}