namespace UserService.Services;

/// <summary>
///     Сервис для генерации токенов
/// </summary>
public interface IJWTService
{
    /// <summary>
    ///     Добавить refresh токен
    /// </summary>
    void AddRefreshToken(HttpContext context);
    
    /// <summary>
    ///     Добавить access токены
    /// </summary>
    void AddAccessToken(HttpContext context);
}