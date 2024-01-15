using System.ComponentModel.DataAnnotations.Schema;

namespace RuleEntities.Entities.SpecialRules;

/// <summary>
///     Спец правила
/// </summary>
[Table("band_special_rules")]
public class BandSpecialRuleEntity : BaseRuleEntity
{
    /// <summary>
    ///     Id банды 
    /// </summary>
    [ForeignKey(nameof(Band))]
    [Column("band_id")]
    public long BandId { get; set; }
    
    /// <summary>
    ///     Навигационное свойство
    /// </summary>
    public BandEntity Band { get; set; }
}