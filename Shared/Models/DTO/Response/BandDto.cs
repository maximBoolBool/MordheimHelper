using SharedEntities.Models.DTO.Response.SpecialRuleModels;

namespace SharedEntities.Models.DTO.Response;

/// <summary>
///     Модель банды
/// </summary>
public class BandDto
{
    /// <summary>
    ///     Id
    /// </summary>
    public long BandId { get; set; }
    
    /// <summary>
    ///     Тип банды
    /// </summary>
    public long TypeId { get; set; }
    
    /// <summary>
    ///     Название
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Максимальная цена
    /// </summary>
    public int MaxCost { get; set; }
    
    /// <summary>
    ///     Текущая цена
    /// </summary>
    public int CurrentCost { get; set; }
    
    /// <summary>
    ///     Спец правила банды
    /// </summary>
    public List<BandSpecialRuleDto> Rules { get; set; }
    
    /// <summary>
    ///     Отряды банды
    /// </summary>
    public List<UnitDto> Units { get; set; }
}