using SharedServices.Repositories;
using UserEntities.Repositories.Impl;

namespace UserEntities.Repositories;

public interface IUserDbWorker : IDisposable, IDatabase
{
    public IBandRepository Bands { get; }
    
    public IUserRepository Users { get; }
    
    public IUnitRepository Units { get; }
}