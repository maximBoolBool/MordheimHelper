using Microsoft.EntityFrameworkCore;
using UserEntities.Entities;

namespace UserEntities.Repositories.Impl;

/// <inheritdoc cref="IUnitRepository"/>
internal class UserRepository : BaseRepositiry<UserEntity>, IUserRepository
{
    public UserRepository(DbContext dbContext) : base(dbContext) { }
    
    public async Task<UserEntity?> FindByLogin(string login, CancellationToken cancellationToken)
    {
        return await _dbContext.Set<UserEntity>()
            .FirstOrDefaultAsync(u => u.Login == login, cancellationToken);
    }
}