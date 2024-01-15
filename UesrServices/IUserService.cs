using UesrServices.Models;

namespace UesrServices;

/// <summary>
///     Сервис для работы с пользователями 
/// </summary>
public interface IUserService
{
    /// <summary>
    ///     Зарегестрировать нового пользователя
    /// </summary>
    /// <returns></returns>
    Task<bool> RegistrateUserAsync(UserRequestDto userRequest, CancellationToken cancellationToken);

    /// <summary>
    ///     Изменить пользователя
    /// </summary>
    /// <returns></returns>
    Task<bool> UpdateUserAsync(UserRequestDto user, CancellationToken cancellationToken);

    /// <summary>
    ///     Аутентифицировать пользователя
    /// </summary>
    /// <returns></returns>
    Task<bool> AuthenticateAsync();

    /// <summary>
    ///     Удалить пользователя
    /// </summary>
    /// <returns></returns>
    Task<bool> DeleteUserAsync(long id, CancellationToken cancellationToken);
}