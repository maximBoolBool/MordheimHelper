using Newtonsoft.Json;

namespace RuleEntities.Entities;

/// <summary>
///     Профиль отряда
/// </summary>
public class UnitProfilEntity
{
    /// <summary>
    ///     Передвижение отряда
    /// </summary>
    [JsonProperty("move")]
    public int Move { get; set; }
    
    /// <summary>
    ///     Умение в ближнем бою
    /// </summary>
    [JsonProperty("weapon_skill")]
    public int WeaponSkil { get; set; }
    
    /// <summary>
    ///     Точность в далнем бою
    /// </summary>
    [JsonProperty("balistic_skill")]
    public int BalisticSkill { get; set; }
    
    /// <summary>
    ///     Сила
    /// </summary>
    [JsonProperty("strength")]
    public int Strength { get; set; }
    
    /// <summary>
    ///     Устойчивость
    /// </summary>
    [JsonProperty("toughness")]
    public int Toughness { get; set; }
    
    /// <summary>
    ///     Количество ран
    /// </summary>
    [JsonProperty("wounds")]
    public int Wounds { get; set; }
    
    /// <summary>
    ///     Инициатива
    /// </summary>
    [JsonProperty("initiative")]
    public int Initiative { get; set; }
    
    /// <summary>
    ///     Лидервство
    /// </summary>
    [JsonProperty("leader_ship")]
    public int LeaderShip { get; set; }
}