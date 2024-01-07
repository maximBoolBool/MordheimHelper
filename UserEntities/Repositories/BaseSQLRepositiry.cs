using Microsoft.EntityFrameworkCore;
using UserEntities.Entities;

namespace UserEntities.Repositories;

/// <summary>
///     Базовый репозиторий для SQL бд
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class BaseSQLRepositiry<T> : ISQLRepository<T> where T : BaseEntity
{
    private readonly DbContext _dbContext;

    public BaseSQLRepositiry(DbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task Create(T entity, CancellationToken cancellationToken)
    {
        _dbContext.Set<T>().Add(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task Update(T entity, CancellationToken cancellationToken)
    {
        _dbContext.Set<T>().Update(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task Remove(long id, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
        if (entity != null) _dbContext.Set<T>().Remove(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public Task<T?> FindById(long id, CancellationToken cancellationToken)
    {
        return _dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }

    public IQueryable<T> CreateQuery()
    {
        return _dbContext.Set<T>().AsQueryable();
    }


    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}