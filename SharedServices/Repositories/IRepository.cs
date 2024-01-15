namespace SharedServices;

/// <summary>
///     Репозитория для SQL бд
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T>
{
    /// <summary>
    ///     Сохрагить изменения
    /// </summary>
    /// <returns></returns>
    Task SaveChangesAsync();

    /// <summary>
    ///    Создать запрос к бд 
    /// </summary>
    /// <returns></returns>
    public IQueryable<T> CreateQuery();
    
    /// <summary>
    ///     Добавить
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public abstract Task Create(T entity, CancellationToken cancellationToken);

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
    public abstract Task<T?> FindById(long id, CancellationToken cancellationToken);
}