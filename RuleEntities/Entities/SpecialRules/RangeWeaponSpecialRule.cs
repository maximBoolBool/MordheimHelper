using System.ComponentModel.DataAnnotations.Schema;

namespace RuleEntities.Entities.SpecialRules;

/// <summary>
///     Спецправила для оружия дальнего боя
/// </summary>
[Table("range_weapon_special_rules")]
public class RangeWeaponSpecialRule : BaseRuleEntity
{
    /// <summary>
    ///     Id оружия
    /// </summary>
    [Column("weapon_id")]
    [ForeignKey(nameof(Weapon))]
    public long WeaponId { get; set; }
    
    /// <summary>
    ///     Навигационное свойство
    /// </summary>
    public List<RangeWeaponEntity> Weapon { get; set; }
}