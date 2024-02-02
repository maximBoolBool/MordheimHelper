using Newtonsoft.Json;
using RuleServices.Enums;

namespace RuleServices.Models.Dto;

public class EqiepmentQuery
{
    [JsonProperty("id")]
    public long Id { get; set; }
    
    [JsonProperty("type")]
    public EqipmentType Type { get; set; } 
}