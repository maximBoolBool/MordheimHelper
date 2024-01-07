using Newtonsoft.Json;

namespace RuleEntities.Entities;

/// <summary>
///     Спец правила банды во время игры
/// </summary>
public class BandSpecialRuleEntity
{
    /// <summary>
    ///     Id сущности
    /// </summary>
    [JsonProperty("id")]
    public long Id { get; set; }
    
    /// <summary>
    ///     Описание 
    /// </summary>
    [JsonProperty("desciption")]
    public string Description { get; set; }
}