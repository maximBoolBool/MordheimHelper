using Newtonsoft.Json;

namespace SharedEntities;

/// <summary>
///     Навыки
/// </summary>
public enum SkillType
{
    /// <summary>
    ///     Ближний бой
    /// </summary>
    [JsonProperty("combat")]
    Combat, 
    
    /// <summary>
    ///     Дальний бой
    /// </summary>
    [JsonProperty("shooting")] 
    Shooting,
    
    /// <summary>
    ///     Знания
    /// </summary>
    [JsonProperty("academic")]
    Academic,
    
    /// <summary>
    ///     Сила
    /// </summary>
    [JsonProperty("strngth")] 
    Strength,
    
    /// <summary>
    ///     Скорость
    /// </summary>
    [JsonProperty("speed")]
    Speed
}