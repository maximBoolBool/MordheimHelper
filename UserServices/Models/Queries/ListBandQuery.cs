using Newtonsoft.Json;
using SharedEntities.Models.DTO;

namespace UesrServices.Models.Queries;

/// <summary>
///     Получить коллекцию банд
/// </summary>
public class ListBandQuery : IPageQuery
{
    /// <summary>
    ///     Фильтр банд
    /// </summary>
    [JsonProperty("band_types")]
    public long[]? BandTypeIds { get; set; }
    
    /// <summary>
    ///     Ограничение масимального размера
    /// </summary>
    [JsonProperty("max_cost")]
    public int? MaxCost {get; set; }
    
    /// <summary>
    ///     Ограничение минимального размера
    /// </summary>
    [JsonProperty("min_cost")]
    public int? MinCost { get; set; }
    
    /// <summary>
    ///     Флаг поиска банд
    /// </summary>
    [JsonProperty("is_user_only")]
    public bool IsUserOnly { get; set; }

    /// <summary>
    ///     Пропустить
    /// </summary>
    [JsonProperty("skip")]
    public int Skip { get; set; }
    
    /// <summary>
    ///     Взять
    /// </summary>
    [JsonProperty("take")]
    public int Take { get; set; }
}