using Newtonsoft.Json;
using RuleServices.Enums;
using SharedEntities.Models.DTO;

namespace RuleServices.Models.Dto;

public class EquepmentListQuery : IPageQuery
{
    [JsonProperty("types")]
    public EqipmentType[]? Types { get; set; }

    [JsonProperty("skip")]
    public int Skip { get; set; } = 25;

    [JsonProperty("take")]
    public int Take { get; set; } = 25;
}