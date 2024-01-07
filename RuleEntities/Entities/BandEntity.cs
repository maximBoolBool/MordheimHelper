namespace RuleEntities.Entities;

/// <summary>
///     Сущность правил банды
/// </summary>
public class BandEntity
{
    /// <summary>
    ///     Id банды
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    ///     Название
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    ///     Отряды
    /// </summary>
    public List<UnitEntity> Units { get; set; }

    /// <summary>
    ///     Спец правила
    /// </summary>
    public List<BandSpecialRuleEntity> Rules { get; set; }
}