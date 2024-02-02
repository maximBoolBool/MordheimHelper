using Newtonsoft.Json;

namespace RuleServices.Models;

public abstract class SpecialRuleModel
{
    [JsonProperty("id")]
    public long Id { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("description")]
    public string Description { get; set; }
}