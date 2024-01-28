using SharedEntities.Models.DTO.Request;

namespace UesrServices;

/// <summary>
///     Сервис для работы с пользователями 
/// </summary>
public interface IUserService
{
    /// <summary>
    ///     Зарегестрировать нового пользователя
    /// </summary>
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

    /// <summary>
    ///     Выйти из учетной записи
    /// </summary>
    Task LogoffAsync(long id, CancellationToken cancellationToken);
    
    /// <summary>
    ///     Обновить токены
    /// </summary>
    Task RefreshAsync();
}