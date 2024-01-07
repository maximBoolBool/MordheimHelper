using MongoDB.Bson;
using MongoDB.Driver;
using SharedServices;

namespace RuleEntities.Repositories;

/// <summary>
///     Базовый репозиторий для MongoDb
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class MongoDbRepository<T> : IRepository<T>
{
    private readonly IMongoDatabase _db;

    public MongoDbRepository(IMongoDatabase db)
    {
        _db = db;
    }
    
    /// <inheritdoc cref="IRepository{T}"/>
    public async Task Create(T entity, CancellationToken cancellationToken)
    {
        var collection = _db.GetCollection<T>(typeof(T).Name.ToLower());
        await collection.InsertOneAsync(entity, cancellationToken);
    }

    /// <inheritdoc cref="IRepository{T}"/>
    public async Task Update(T entity, CancellationToken cancellationToken)
    {
        var collection = _db.GetCollection<T>(typeof(T).Name.ToLower());
        var filter = Builders<T>.Filter.Empty;
        await collection.ReplaceOneAsync(filter, entity, cancellationToken : cancellationToken);
    }

    /// <inheritdoc cref="IRepository{T}"/>
    public async Task<T?> FindById(string id, CancellationToken cancellationToken)
    {
        var collection = _db.GetCollection<T>(typeof(T).Name.ToLower());
        var objectId = new ObjectId(id);
        var filter = Builders<T>.Filter.Eq("_id", objectId);
        var cursor = await collection.FindAsync(filter, cancellationToken: cancellationToken);
        return await cursor.FirstOrDefaultAsync(cancellationToken: cancellationToken);
    }

    /// <inheritdoc cref="IRepository{T}"/>
    public async Task Remove(string id, CancellationToken cancellationToken)
    {
        var collection = _db.GetCollection<T>(typeof(T).Name.ToLower());
        var objectId = new ObjectId(id);
        var filter = Builders<T>.Filter.Eq("_id", objectId);
        await collection.DeleteOneAsync(filter, cancellationToken);
    }
}