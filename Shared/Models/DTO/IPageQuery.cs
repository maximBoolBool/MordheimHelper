using Newtonsoft.Json;

namespace SharedEntities.Models.DTO;

public interface IPageQuery
{
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