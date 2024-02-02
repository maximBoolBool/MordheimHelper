using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace RuleServices.Enums;

public enum EqipmentType
{
    [JsonProperty("close_combat")]
    CloseCombatWeapon = 0,
    
    [JsonProperty("range_wawepon")]
    RangeWeapon = 1,
    
    [JsonProperty("armour")]
    Armour = 2,
}