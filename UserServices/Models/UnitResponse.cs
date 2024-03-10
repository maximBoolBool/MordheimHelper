namespace UesrServices.Models;


/// <summary>
///     Отряд
/// </summary>
public class UnitResponse
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public List<RangeWeaponResponse> CurrentRangeWeapons { get; set;}
    
    public List<CloseWeaponResponse> CurrentCloseWeapons { get; set; }
    
    public ArmorResponse CurrentArmor {get; set; }
}