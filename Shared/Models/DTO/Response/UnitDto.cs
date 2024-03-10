using Newtonsoft.Json;
using RuleServices.Models;
using SharedEntities.Models.DTO.Response.SpecialRuleModels;

namespace SharedEntities.Models.DTO.Response;

public class UnitDto
{
    /// <summary>
    ///     Id
    /// </summary>
    [JsonProperty("id")]
    public long Id { get; set; }
    
    /// <summary>
    ///     Название модели
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
    
    /// <summary>
    ///     Максимальное ограничение
    /// </summary>
    [JsonProperty("max_unit_count")]
    public string MaxUnitCount { get; set; }
    
    /// <summary>
    ///     Цена за модель
    /// </summary>
    [JsonProperty("unit_cost")]
    public int UnitCost { get; set; }

    /// <summary>
    ///     Список доступной брони
    /// </summary>
    [JsonProperty("armors")]
    public List<ArmorDto> Armors { get; set; }
    
    /// <summary>
    ///     Список доступного оружия
    /// </summary>
    [JsonProperty("weapons")]
    public List<CloseWeaponModel> Weapons { get; set; }
    
    /// <summary>
    ///     Список доступного удаленного оружия
    /// </summary>
    [JsonProperty("range_weapons")]
    public List<RangeWeaponDto> RangeWeapons { get; set; }
    
    /// <summary>
    ///     Правила
    /// </summary>
    [JsonProperty("rules")]
    public List<UnitSpecialRuleDto> Rules { get; set; }

    #region Profile

    /// <summary>
    ///     Количество передвижений
    /// </summary>
    [JsonProperty("move")]
    public int Move { get; set; }
    
    /// <summary>
    ///     Умение ближнего боя
    /// </summary>
    [JsonProperty("weapon_skill")]
    public int WeaponSkill { get; set; }
    
    /// <summary>
    ///     Умение стрелять
    /// </summary>
    [JsonProperty("balistic_skill")]
    public int BalisticSkill { get; set; }

    /// <summary>
    ///     Сила
    /// </summary>
    [JsonProperty("strength")]
    public int Strength { get; set; }
    
    /// <summary>
    ///     Стойкость
    /// </summary>
    [JsonProperty("toughest")]
    public int Toughest { get; set; }
    
    /// <summary>
    ///     Количетсов ран
    /// </summary>
    [JsonProperty("woonds")]
    public int Woonds { get; set; }
    
    /// <summary>
    ///     Инициатива
    /// </summary>
    [JsonProperty("initiative")]
    public int Initiative { get; set; }
    
    /// <summary>
    ///     Количестов атак
    /// </summary>
    [JsonProperty("attacks")]
    public int Attacks { get; set; }
    
    /// <summary>
    ///     Лидерство
    /// </summary>
    [JsonProperty("leadership")]
    public int Leadership { get; set; }
    
    #endregion
}