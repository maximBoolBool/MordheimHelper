namespace RuleEntities.Repositories;

public class IRuleDatabase
{
    public IArmorRepository Armors { get; }
    
    public IBandRepository Bands { get; }
    
    public ICloseCombatWeaponRepository CloseCombatWeapons { get; set; }
    
    public IRangeWeaponRepository RangeWeapons { get; set; }
    
    public IUnitRepository Units { get; set; }
    
    public IUnitWeaponSpecialRuleRepository UnitSpecialRules { get; set; }
}