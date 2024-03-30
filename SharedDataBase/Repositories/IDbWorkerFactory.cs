namespace SharedServices.Repositories;

public interface IDbWorkerFactory<TDatabase>
    where TDatabase : IDbWorker
{
    TDatabase CreateScopeDatabase();
}