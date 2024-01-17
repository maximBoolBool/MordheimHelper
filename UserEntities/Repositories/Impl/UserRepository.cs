using Microsoft.EntityFrameworkCore;
using SharedServices.Repositories;
using UserEntities.Entities;
using UserEntities.Models;

namespace UserEntities.Repositories.Impl;

/// <inheritdoc cref="IUnitRepository"/>
internal class UserRepository : BaseRepositiry<UserEntity, UserFilter>, IUserRepository
{
    public UserRepository(DbContext dbContext) : base(dbContext) { }
    
    public async Task<UserEntity?> FindByLogin(string login, CancellationToken cancellationToken)
    {
        return await _dbContext.Set<UserEntity>()
            .FirstOrDefaultAsync(u => u.Login == login, cancellationToken);
    }
}