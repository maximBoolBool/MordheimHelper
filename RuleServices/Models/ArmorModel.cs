using Newtonsoft.Json;
using RuleServices.Models.Dto.Response;

namespace RuleServices.Models;

public class ArmorModel : IEquipmentResponse
{
    [JsonProperty("id")]
    public long Id { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("description")]
    public string Description { get; set; }
    
    [JsonProperty("rules")]
    public ArmorRuleModel[] Rules { get; set; }
}