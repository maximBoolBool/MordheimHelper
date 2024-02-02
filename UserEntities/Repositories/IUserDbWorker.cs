using SharedServices.Repositories;

namespace UserEntities.Repositories;

public interface IUserDbWorker : IDisposable, IDbWorker
{
    public IBandRepository Bands { get; }
    
    public IUserRepository Users { get; }
    
    public IUnitRepository Units { get; }
}