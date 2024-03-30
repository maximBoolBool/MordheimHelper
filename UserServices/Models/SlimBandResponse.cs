using Newtonsoft.Json;

namespace UesrServices.Models;

/// <summary>
///     Тонкая DTO для банды
/// </summary>
public class SlimBandResponse
{
    /// <summary>
    ///     ID
    /// </summary>
    [JsonProperty("id")]
    public long Id { get; set; }
    
    /// <summary>
    ///     Название
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Максиимальное ограничение очков
    /// </summary>
    [JsonProperty("max_constraint_price")]
    public int MaxConstraintPrice { get; set; }
    
    /// <summary>
    ///     Текущее количестов очков
    /// </summary>
    [JsonProperty("current_price")]
    public int CurrentPrice { get; set; }
}