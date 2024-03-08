using System.ComponentModel.DataAnnotations.Schema;
using RuleEntities.Entities.SpecialRules;
using SharedEntities.Entities;

namespace RuleEntities.Entities;

/// <summary>
///     Отряд
/// </summary>
[Table("units")]
public class UnitEntity : BaseEntity
{
    /// <summary>
    ///     Название
    /// </summary>
    [Column("name")]
    public string Name { get; set; }

    /// <summary>
    ///     Максимальное количество отряда
    /// </summary>
    [Column("max_unit_count")]
    public int MaxUnitCount { get; set; }
    
    /// <summary>
    ///     Стоимость отряда
    /// </summary>
    [Column("unit_cost")]
    public int UnitCost { get; set; }
    
    #region Profile

    /// <summary>
    ///     Количество передвижения
    /// </summary>
    [Column("move")]
    public int Move { get; set; }
    
    /// <summary>
    ///     Умение ближнего боя
    /// </summary>
    [Column("weapon_skill")]
    public int WeaponSkill { get; set; }
    
    /// <summary>
    ///     Умение стрелять
    /// </summary>
    [Column("balistic_skill")]
    public int BalisticSkill { get; set; }

    /// <summary>
    ///     Сила
    /// </summary>
    [Column("strength")]
    public int Strength { get; set; }
    
    /// <summary>
    ///     Стойкость
    /// </summary>
    [Column("toughest")]
    public int Toughest { get; set; }
    
    /// <summary>
    ///     Количетсов ран
    /// </summary>
    [Column("woonds")]
    public int Woonds { get; set; }
    
    /// <summary>
    ///     Инициатива
    /// </summary>
    [Column("initiative")]
    public int Initiative { get; set; }
    
    /// <summary>
    ///     Количестов атак
    /// </summary>
    [Column("attacks")]
    public int Attacks { get; set; }
    
    /// <summary>
    ///     Лидерство
    /// </summary>
    [Column("leadership")]
    public int Leadership { get; set; }
    
    #endregion
    
    /// <summary>
    ///     Id банды
    /// </summary>
    [ForeignKey(nameof(Band))]
    [Column("band_id")]
    public long BandId { get; set; }

    /// <summary>
    ///     Банда
    /// </summary>
    public BandEntity Band { get; set; }
    
    /// <summary>
    ///     Доступная броня
    /// </summary>
    public List<ArmorEntity> Armors { get; set; }
    
    /// <summary>
    ///     Доступное оружие ближнего боя
    /// </summary>
    public List<CloseCombatWeaponEntity> CloseCombatWeapons { get; set; }
    
    /// <summary>
    ///     Доступное оружие дальнего боя
    /// </summary>
    public List<RangeWeaponEntity> RangeWeapons { get; set; }
    
    /// <summary>
    ///     Спец правила отряда
    /// </summary>
    public List<UnitSpecialRuleEntity> Rules { get; set; }
}