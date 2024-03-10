namespace SharedServices;

/// <summary>
///     Репозитория для SQL бд
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface IRepository<TResponse, TFilter>
{
    public Task<TResponse[]> ListAsync(CancellationToken cancellationToken);

    /// <summary>
    ///     Сохрагить изменения
    /// </summary>
    /// <returns></returns>
    Task SaveChangesAsync();

    /// <summary>
    ///    Создать запрос к бд 
    /// </summary>
    /// <returns></returns>
    public IQueryable<TResponse> CreateQuery();
    
    /// <summary>
    ///     Добавить
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public abstract Task CreateAsync(TResponse entity, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Удалить по Id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public abstract Task Remove(long id, CancellationToken cancellationToken);

    /// <summary>
    ///     Найти по id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public abstract Task<TResponse?> FindById(long id, CancellationToken cancellationToken);
}