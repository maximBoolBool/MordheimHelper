namespace SharedServices.Repositories;

public interface IDbWorkerFactory<TDatabase> : IDbWorker
    where TDatabase : IDbWorker
{
    TDatabase? CreateScopeDatabase();
}