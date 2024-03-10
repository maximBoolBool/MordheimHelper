using Newtonsoft.Json;

namespace SharedEntities.Models.DTO.Response.SpecialRuleModels;

public abstract class BaseSpecialRuleDto
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