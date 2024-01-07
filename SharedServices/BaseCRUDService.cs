namespace SharedServices;

/// <summary>
///     Базовый CRUD сервис
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class BaseCRUDService<T>
{
    /// <summary>
    ///     Добавить
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public abstract Task Create(T entity, CancellationToken cancellationToken);

    /// <summary>
    ///     Изменить 
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public abstract Task Update(T entity, CancellationToken cancellationToken);

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
    public abstract Task<T?> FindBy(int id, CancellationToken cancellationToken);
}