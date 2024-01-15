using System.ComponentModel.DataAnnotations.Schema;
using SharedEntities.Entities;

namespace UserEntities.Entities;

/// <summary>
///     Сущность отряда в банде
/// </summary>
[Table("untis")]
public class UnitEntity : BaseEntity
{
    /// <summary>
    ///     название банды
    /// </summary>
    [Column("name")] 
    public string Name { get; set; }
    
    /// <summary>
    ///     Id правил миниатюры
    /// </summary>
    [Column("model_rule_id")]
    public string ModelRuleId { get; set; }
    
    /// <summary>
    ///     Id оружия ближнего боя миниатюры
    /// </summary>
    [Column("close_combat_weapon_rule_id")] 
    public string CloseCombatWeaponRuleId { get; set; }
    
    /// <summary>
    ///     Id оружия дальнего боя миниатюры
    /// </summary>
    [Column("range_weapon_rule_id")]
    public string RangeWeaponRuleId { get; set; }
    
    /// <summary>
    ///     Id купленных доспехов
    /// </summary>
    [Column("armors_rule_ids")]
    public List<string> ArmorsRuleIds { get; set; }
    
    /// <summary>
    ///     Id банды
    /// </summary>
    [Column("band_id")]
    [ForeignKey(nameof(Band))]
    public long BandId { get; set; }
    
    /// <summary>
    ///     Навигационное свойство банды
    /// </summary>
    public BandEntity Band { get; set; }
}