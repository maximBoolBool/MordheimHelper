using Newtonsoft.Json;

namespace SharedEntities.Models.DTO.Request;

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