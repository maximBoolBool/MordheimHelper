using SharedServices;
using UserEntities.Entities;

namespace UserEntities.Repositories;

public interface IUserRepository : IRepository<UserEntity>
{
    public Task<UserEntity?> FindByLogin(string login, CancellationToken cancellationToken);
}