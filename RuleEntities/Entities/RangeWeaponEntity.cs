using MongoDB.Bson;
using Newtonsoft.Json;

namespace RuleEntities.Entities;

/// <summary>
///     Оружие дальнего боя
/// </summary>
public class RangeWeaponEntity
{
    /// <summary>
    ///     Id сущности
    /// </summary>
    [JsonProperty("id")]
    public ObjectId Id { get; set; }

    /// <summary>
    ///     Сила
    /// </summary>
    [JsonProperty("strength")]
    public int Strength { get; set; }
    
    /// <summary>
    ///     Радиус действия
    /// </summary>
    [JsonProperty("range")]
    public int Range { get; set; }
    
    /// <summary>
    ///     Стоймость в очках
    /// </summary>
    [JsonProperty("point_cost")]
    public int PointCost { get; set; }

    /// <summary>
    ///     Специальные правила
    /// </summary>
    [JsonProperty("rulse")]
    public List<SpecialRuleEntity> SpecialRules { get; set; }
}