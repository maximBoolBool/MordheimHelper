using SharedServices.Repositories.Impl;

namespace RuleEntities.Repositories.Impl;

internal class RuleDbWorker : BaseDbWorker, IRuleDbWorker
{
    public RuleDbWorker(
        RuleDbContext dbContext,
        IUnitRepository units,
        IBandRepository bands,
        IArmorRepository armors,
        IRangeWeaponRepository rangeWeapons,
        ICloseCombatWeaponRepository closeCombatWeapons,
        IWeaponSpecialRuleRepository specialRules
        ) : base(dbContext)
    {
        Armors = armors;
        Bands = bands;
        CloseCombatWeapons = closeCombatWeapons;
        RangeWeapons = rangeWeapons;
        Units = units;
        SpecialRules = specialRules;
    }

    public IArmorRepository Armors { get; }
    
    public IBandRepository Bands { get; }
    
    public ICloseCombatWeaponRepository CloseCombatWeapons { get; set; }
    
    public IRangeWeaponRepository RangeWeapons { get; set; }
    
    public IUnitRepository Units { get; set; }

    public IWeaponSpecialRuleRepository SpecialRules { get; set; }

    public void Dispose()
    {
        DbContext.Dispose();
    }
}