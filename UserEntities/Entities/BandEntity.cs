using System.ComponentModel.DataAnnotations.Schema;
using SharedEntities.Entities;

namespace UserEntities.Entities;

/// <summary>
///     Сущность банды
/// </summary>
[Table("bands")]
public class BandEntity : BaseEntity
{
    /// <summary>
    ///     Название банды
    /// </summary>
    [Column("name")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Текущая стоимость банды
    /// </summary>
    [Column("current_point_cost")]
    public int CurrentPointCost { get; set; }
    
    /// <summary>
    ///     Максимальная стоимость банды
    /// </summary>
    [Column("max_point_cost")]
    public int MaxPointCost { get; set; }
    
    /// <summary>
    ///     Id на правила  
    /// </summary>
    [Column("rule_id")]
    public string RuleId { get; set; }
    
    /// <summary>
    ///     Id пользователя
    /// </summary>
    [Column("user_id")]
    [ForeignKey(nameof(User))]
    public long UserId { get; set; }
    
    /// <summary>
    ///     Навигациооное свойство
    /// </summary>
    public UserEntity User { get; set; }
}