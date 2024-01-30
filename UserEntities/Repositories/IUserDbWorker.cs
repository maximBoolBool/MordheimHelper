using SharedServices.Repositories;
using UserEntities.Repositories.Impl;

namespace UserEntities.Repositories;

public interface IUserDbWorker : IDisposable, IDatabaseWorker
{
    public IBandRepository Bands { get; }
    
    public IUserRepository Users { get; }
    
    public IUnitRepository Units { get; }
}