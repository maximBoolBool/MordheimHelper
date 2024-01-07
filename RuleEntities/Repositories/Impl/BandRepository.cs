using MongoDB.Driver;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IBandRepository"/>
public class BandRepository : MongoDbRepository<BandRepository>, IBandRepository
{
    public BandRepository(IMongoDatabase db) : base(db) { }
}