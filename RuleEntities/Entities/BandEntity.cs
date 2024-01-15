using System.ComponentModel.DataAnnotations.Schema;
using RuleEntities.Entities.SpecialRules;
using SharedEntities.Entities;

namespace RuleEntities.Entities;

/// <summary>
///     Банда
/// </summary>
public class BandEntity : BaseEntity
{
    /// <summary>
    ///     Навзвание
    /// </summary>
    [Column("name")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Отряды
    /// </summary>
    public List<UnitEntity> Units { get; set; }
    
    /// <summary>
    ///     Спец правила отряда
    /// </summary>
    public List<BandSpecialRuleEntity> SpecialRules { get; set; }
}