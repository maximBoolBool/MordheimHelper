using System.ComponentModel.DataAnnotations.Schema;
using RuleEntities.Entities.SpecialRules;
using SharedEntities.Entities;

namespace RuleEntities.Entities;

/// <summary>
///     Оружие ближнего боя
/// </summary>
[Table("close_combat_weapons")]
public class CloseCombatWeaponEntity : BaseEntity
{
    /// <summary>
    ///     Спец правила оружия
    /// </summary>
    public List<CloseCombatWeaponSpecialRuleEntity> Rules { get; set; }
}