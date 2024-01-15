using System.ComponentModel.DataAnnotations.Schema;
using SharedEntities.Entities;

namespace RuleEntities.Entities.SpecialRules;

/// <summary>
///     Сущность базовых правил
/// </summary>
public abstract class BaseRuleEntity : BaseEntity
{
    /// <summary>
    ///     Имя
    /// </summary>
    [Column("name")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Описание
    /// </summary>
    [Column("description")]
    public string Description { get; set; }
}