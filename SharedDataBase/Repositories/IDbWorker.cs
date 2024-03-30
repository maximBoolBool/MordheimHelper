namespace SharedServices.Repositories;

public interface IDbWorker
{
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}