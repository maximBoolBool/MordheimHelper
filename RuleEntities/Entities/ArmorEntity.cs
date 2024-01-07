using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace RuleEntities.Entities;

/// <summary>
///     Броня модели
/// </summary>
public class ArmorEntity
{
    /// <summary>
    ///     Id сущности
    /// </summary>
    [JsonProperty("id")]
    public ObjectId Id { get; set; }
    /// <summary>
    ///     Описание 
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }
    
    /// <summary>
    ///     Спецправила
    /// </summary>
    [JsonProperty("rules")]
    public List<SpecialRuleEntity> SpecialRules { get; set; } 
}