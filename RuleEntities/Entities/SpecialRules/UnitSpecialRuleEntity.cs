using System.ComponentModel.DataAnnotations.Schema;

namespace RuleEntities.Entities.SpecialRules;

/// <summary>
///     
/// </summary>
[Table("unit_special_rules")]
public class UnitSpecialRuleEntity : BaseRuleEntity
{
    /// <summary>
    ///     Id отряда
    /// </summary>
    [ForeignKey(nameof(Unit))]
    [Column("unit_id")]
    public long UnitId { get; set; }
    
    /// <summary>
    ///     Навигационное свойство
    /// </summary>
    public List<UnitEntity> Unit { get; set; }
}