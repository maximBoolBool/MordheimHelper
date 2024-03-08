using System.Net;
using Microsoft.EntityFrameworkCore;
using SharedEntities.Entities;
using SharedEntities.Models;

namespace SharedServices.Repositories.Impl;

/// <summary>
///     Базовый репозиторий для SQL бд
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TFilter"></typeparam>
public abstract class BaseRepositiry<TEntity, TFilter> : IRepository<TEntity, TFilter>
    where TEntity : BaseEntity
    where TFilter : IBaseFilter
{
    protected readonly DbContext _dbContext;

    protected readonly DbSet<TEntity> _dbSet;

    /// <summary>
    ///     .ctor
    /// </summary>
    /// <param name="dbContext"></param>
    public BaseRepositiry(DbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = dbContext.Set<TEntity>();
    }
    
    /// <inheritdoc cref="IRepository{T}"/>
    public async Task CreateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);
    }

    /// <inheritdoc cref="IRepository{T}"/>
    public async Task Remove(long id, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

        if (entity == null)
            throw new ErrorException(HttpStatusCode.NotFound, "Can not found");
        
        entity.IsActive = false;
        _dbContext.Update(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc cref="IRepository{T}"/>
    public async Task<TEntity?> FindById(long id, CancellationToken cancellationToken)
    {
        return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }
    
    /// <inheritdoc cref="IRepository{T}"/>
    public IQueryable<TEntity> CreateQuery()
    {
        return _dbContext.Set<TEntity>().AsQueryable();
    }

    /// <inheritdoc cref="IRepository{T}"/>
    public virtual async Task<TEntity[]> ListAsync(CancellationToken cancellationToken)
    {
        return await _dbSet.ToArrayAsync(cancellationToken);
    }

    /// <inheritdoc cref="IRepository{T}"/>
    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}