using MongoDB.Bson;
using Newtonsoft.Json;
using SharedEntities;

namespace RuleEntities.Entities;

/// <summary>
///     Сущность отряда
/// </summary>
public class UnitEntity
{
    /// <summary>
    ///  Id сущности
    /// </summary>
    [JsonProperty("id")]
    public ObjectId Id { get; set; }
    
    /// <summary>
    ///     Название Отряда
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Цена в очках
    /// </summary>
    [JsonProperty("point_cost")]
    public int PointCost { get; set; }
    
    /// <summary>
    ///     Оганичение в численности
    /// </summary>
    [JsonProperty("max_unit_limit")]
    public int MaxUnitLimit { get; set; }
    
    /// <summary>
    ///     Тип юнита
    /// </summary>
    [JsonProperty("type")]
    public ModelType Type { get; set; } 
    
    /// <summary>
    ///     Профиль модели
    /// </summary>
    [JsonProperty("profile")]
    public UnitProfilEntity Profile { get; set; }
    
    /// <summary>
    ///     Спец правила
    /// </summary>
    [JsonProperty("rules")]
    public List<SpecialRuleEntity> Rules { get; set; }
    
    /// <summary>
    ///     Доступное оружие
    /// </summary>
    [JsonProperty("weapons")]
    public List<CloseCombatWeaponEntity> Weapons { get; set; }
    
    /// <summary>
    ///     Доступное дальнее оружие
    /// </summary>
    [JsonProperty("range_weapons")]
    public List<RangeWeaponEntity> RangeWeapon { get; set; }
    
    /// <summary>
    ///     Доступная броня
    /// </summary>
    [JsonProperty("armours")]
    public List<ArmorEntity> Armours { get; set; }
}