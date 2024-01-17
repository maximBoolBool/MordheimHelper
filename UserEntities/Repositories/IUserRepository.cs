using SharedServices;
using UserEntities.Entities;
using UserEntities.Models;

namespace UserEntities.Repositories;

public interface IUserRepository : IRepository<UserEntity, UserFilter>
{
    public Task<UserEntity?> FindByLogin(string login, CancellationToken cancellationToken);
}