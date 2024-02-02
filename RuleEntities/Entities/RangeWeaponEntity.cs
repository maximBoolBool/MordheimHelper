using System.ComponentModel.DataAnnotations.Schema;
using RuleEntities.Entities.SpecialRules;
using SharedEntities.Entities;

namespace RuleEntities.Entities;

[Table("range_weapons")]
public class RangeWeaponEntity : BaseEntity
{
    /// <summary>
    ///     Расстояние
    /// </summary>
    [Column("range")]
    public int Range { get; set; }
    
    /// <summary>
    ///     Отряды которым доступно оружие
    /// </summary>
    public List<UnitEntity> Units { get; set; }
    
    /// <summary>
    ///     Спец правила оружия
    /// </summary>
    public List<RangeWeaponSpecialRule> Rules { get; set; }
}