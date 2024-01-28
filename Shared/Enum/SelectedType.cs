using Newtonsoft.Json;

namespace SharedEntities;

/// <summary>
///     Статус опции
/// </summary>
public enum SelectedType
{
    /// <summary>
    ///     Выбран
    /// </summary>
    [JsonProperty("selected")]
    Selected,
    
    /// <summary>
    ///     Доступен
    /// </summary>
    [JsonProperty("available")]
    Available,
}