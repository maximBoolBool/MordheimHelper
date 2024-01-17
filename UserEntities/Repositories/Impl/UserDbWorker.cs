namespace UserEntities.Repositories.Impl;

public class UserDbWorker : IUserDbWorker
{
    public UserDbWorker(
        IBandRepository bands,
        IUserRepository users, 
        IUnitRepository units)
    {
        Bands = bands;
        Users = users;
        Units = units;
    }

    public IBandRepository Bands { get; }
    
    public IUserRepository Users { get; }
    
    public IUnitRepository Units { get; }
}