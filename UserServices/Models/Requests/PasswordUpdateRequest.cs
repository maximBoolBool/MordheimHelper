using Newtonsoft.Json;

namespace UesrServices.Models.Requests;

/// <summary>
///     Запрос на смену пароля
/// </summary>
public class PasswordUpdateRequest
{
    /// <summary>
    ///     Новый пароль
    /// </summary>
    [JsonProperty("new_password")]
    public string NewPassword { get; set; }
    
    /// <summary>
    ///     Старый пароль
    /// </summary>
    [JsonProperty("old_password")]
    public string OldPassword { get; set; }
}