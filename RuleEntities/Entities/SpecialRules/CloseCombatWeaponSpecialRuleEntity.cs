using System.ComponentModel.DataAnnotations.Schema;

namespace RuleEntities.Entities.SpecialRules;

/// <summary>
///     Специальные правила для оружия
/// </summary>
[Table("weapon_special_rules")]
public class CloseCombatWeaponSpecialRuleEntity : BaseRuleEntity
{
    /// <summary>
    ///     Id оружия
    /// </summary>
    [ForeignKey(nameof(Weapon))] 
    [Column("weapon_id")]
    public long WeaponId { get; set; }
    
    /// <summary>
    ///     Навигационное свойство
    /// </summary>
    public CloseCombatWeaponEntity Weapon { get; set; }
}