using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
namespace RuleEntities.Entities;

/// <summary>
///   Спец правила
/// </summary>
public class SpecialRuleEntity
{
    /// <summary>
    ///     Id сущности
    /// </summary>
    [JsonProperty("id")]
    public ObjectId Id { get; set; }
    
    /// <summary>
    ///      Название
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Описание правила
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }
}