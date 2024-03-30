using SharedServices.Repositories.Impl;

namespace UserEntities.Repositories.Impl;

public class UserDbWorker : BaseDbWorker, IUserDbWorker
{
    private readonly UserDbContext _dbContext;
    
    public UserDbWorker(
        IBandRepository bands,
        IUserRepository users, 
        IUnitRepository units,
        UserDbContext dbContext) : base(dbContext)
    {
        Bands = bands;
        Users = users;
        Units = units;
        _dbContext = dbContext;
    }

    public IBandRepository Bands { get; }
    
    public IUserRepository Users { get; }
    
    public IUnitRepository Units { get; }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}