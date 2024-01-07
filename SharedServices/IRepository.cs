using System.Linq.Expressions;

namespace SharedServices;

/// <summary>
///     Базовый класс репозитория
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T>
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
    public abstract Task Remove(string id, CancellationToken cancellationToken);

    /// <summary>
    ///     Найти по id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public abstract Task<T?> FindById(string id, CancellationToken cancellationToken);
}