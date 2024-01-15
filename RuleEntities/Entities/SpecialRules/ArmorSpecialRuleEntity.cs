using System.ComponentModel.DataAnnotations.Schema;

namespace RuleEntities.Entities.SpecialRules;

/// <summary>
///     Спец правила для брони
/// </summary>
[Table("armor_special_rules")]
public class ArmorSpecialRuleEntity : BaseRuleEntity
{
    /// <summary>
    ///     Id брони
    /// </summary>
    [ForeignKey(nameof(Armor))] 
    [Column("armor_id")]
    public long ArmorId { get; set; }
    
    /// <summary>
    ///     Навигационное свойство
    /// </summary>
    public ArmorEntity Armor { get; set; }
}