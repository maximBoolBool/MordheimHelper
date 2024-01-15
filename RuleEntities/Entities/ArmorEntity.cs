using System.ComponentModel.DataAnnotations.Schema;
using RuleEntities.Entities.SpecialRules;
using SharedEntities.Entities;

namespace RuleEntities.Entities;

/// <summary>
///     Сущность брони
/// </summary>
[Table("armors")]
public class ArmorEntity : BaseEntity
{
    /// <summary>
    ///     Навзвание брони
    /// </summary>
    [Column("name")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Описание
    /// </summary>
    [Column("description")]
    public string Description { get; set; }
    
    /// <summary>
    ///     Отряда которым доступна броня
    /// </summary>
    public List<UnitEntity> Units { get; set; }

    /// <summary>
    ///     Правила
    /// </summary>
    public List<ArmorSpecialRuleEntity> Rules { get; set; }
}