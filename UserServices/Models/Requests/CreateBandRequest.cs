using Newtonsoft.Json;

namespace UesrServices.Models.Requests;

/// <summary>
///     Создать новую банду
/// </summary>
public class CreateBandRequest
{
    /// <summary>
    ///     Тип банды правила
    /// </summary>
    [JsonProperty("band_type")]
    public long TypeId { get; set; }
    
    /// <summary>
    ///     Название банды
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Размер банды в очках
    /// </summary>
    [JsonProperty]
    public int BandCostLimit { get; set; }
}