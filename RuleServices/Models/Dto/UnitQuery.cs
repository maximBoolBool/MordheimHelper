using System.Runtime.Serialization;
using Newtonsoft.Json;
using SharedEntities;
using SharedEntities.Models.DTO;

namespace RuleServices.Models.Dto;

public sealed class UnitQuery : IPageQuery
{
    [JsonProperty("band_id")]
    public long BandId;

    [JsonProperty("skip")]
    public int Skip { get; set; }
    
    [JsonProperty("take")]
    public int Take { get; set; }
    
    [JsonProperty("type")]
    public ModelType Type {get;set;}
}