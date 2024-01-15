using Newtonsoft.Json;

namespace UesrServices.Models;

/// <summary>
///     DTO для работы с внешними сервисами
/// </summary>
public class UserRequestDto
{
    /// <summary>
    ///     Логин
    /// </summary>
    [JsonProperty("login")]
    public string Login { get; set; }
    
    /// <summary>
    ///     Пароль
    /// </summary>
    [JsonProperty("password")]
    public string Password { get; set; }
}