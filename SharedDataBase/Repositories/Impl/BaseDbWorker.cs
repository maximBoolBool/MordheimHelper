using Microsoft.EntityFrameworkCore;

namespace SharedServices.Repositories.Impl;

public class BaseDbWorker : IDbWorker
{
    protected readonly DbContext DbContext;
    
    public BaseDbWorker(DbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await DbContext.SaveChangesAsync(cancellationToken);
    }
}