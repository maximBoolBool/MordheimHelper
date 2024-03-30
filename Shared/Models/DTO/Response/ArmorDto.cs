using Newtonsoft.Json;
using SharedEntities.Models.DTO.Response.SpecialRuleModels;

namespace SharedEntities.Models.DTO.Response;

public class ArmorDto : IEquipmentResponse
{
    [JsonProperty("id")]
    public long Id { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("description")]
    public string Description { get; set; }
    
    [JsonProperty("rules")]
    public ArmorRuleDto[] Rules { get; set; }
}