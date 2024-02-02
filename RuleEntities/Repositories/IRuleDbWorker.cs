using SharedServices.Repositories;

namespace RuleEntities.Repositories;

/// <summary>
///     Бд для работы с 
/// </summary>
public interface IRuleDbWorker : IDisposable, IDbWorker
{
    public IArmorRepository Armors { get; }
    
    public IBandRepository Bands { get; }
    
    public ICloseCombatWeaponRepository CloseCombatWeapons { get; set; }
    
    public IRangeWeaponRepository RangeWeapons { get; set; }
    
    public IUnitRepository Units { get; set; }
    
    public IWeaponSpecialRuleRepository SpecialRules { get; set; }
}