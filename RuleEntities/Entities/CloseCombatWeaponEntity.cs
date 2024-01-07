using Newtonsoft.Json;
using SharedEntities;

namespace RuleEntities.Entities;

/// <summary>
///     Сущность оружия
/// </summary>
public class CloseCombatWeaponEntity
{
    /// <summary>
    ///     Id сущности
    /// </summary>
    [JsonProperty("id")]
    public long Id { get; set; }
    
    /// <summary>
    ///     Бонус к силе
    /// </summary>
    [JsonProperty("strength_bonus")]
    public int StrengthBonus { get; set; }

    /// <summary>
    ///     Стоймость в очках
    /// </summary>
    [JsonProperty("point_cost")]
    public int PointCost { get; set; } 
    
    /// <summary>
    ///     Вид оружия
    /// </summary>
    [JsonProperty("type")]
    public CloseCombatWeaponType Type { get; set; }
    
    /// <summary>
    ///     Специальные правила оружия
    /// </summary>
    [JsonProperty("special_rules")]
    public List<SpecialRuleEntity> SpecialRules { get; set; }
}