namespace SharedServices.Repositories;

public interface IDbWorkerFactory<TDatabase> : IDatabaseWorker
    where TDatabase : IDatabaseWorker
{
    TDatabase? CreateScopeDatabase();
}