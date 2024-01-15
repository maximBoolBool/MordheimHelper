using Microsoft.EntityFrameworkCore;
using SharedEntities.Entities;
using SharedServices;

namespace UserEntities.Repositories;

/// <summary>
///     Базовый репозиторий для SQL бд
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class BaseRepositiry<T> : IRepository<T> where T : BaseEntity
{
    protected readonly DbContext _dbContext;

    protected readonly DbSet<T> _dbSet;

    /// <summary>
    ///     .ctor
    /// </summary>
    /// <param name="dbContext"></param>
    public BaseRepositiry(DbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = dbContext.Set<T>();
    }
    
    /// <inheritdoc cref="IRepository{T}"/>
    public async Task Create(T entity, CancellationToken cancellationToken)
    {
        await _dbContext.Set<T>().AddAsync(entity);
    }

    /// <inheritdoc cref="IRepository{T}"/>
    public async Task Remove(long id, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
        entity.IsActive = false;
        _dbContext.Update(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc cref="IRepository{T}"/>
    public async Task<T?> FindById(long id, CancellationToken cancellationToken)
    {
        return await _dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }
    
    /// <inheritdoc cref="IRepository{T}"/>
    public IQueryable<T> CreateQuery()
    {
        return _dbContext.Set<T>().AsQueryable();
    }
    
    /// <inheritdoc cref="IRepository{T}"/>
    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}