using Newtonsoft.Json;

namespace RuleServices.Models.SpecialRuleModels;

public abstract class BaseSpecialRuleModel
{
    /// <summary>
    ///     Id
    /// </summary>
    [JsonProperty("id")]
    public long Id { get; set; }
    
    /// <summary>
    ///     Название
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Описание
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }
}