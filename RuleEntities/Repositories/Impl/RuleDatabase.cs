namespace RuleEntities.Repositories.Impl;

public class RuleDatabase : IRuleDatabase
{
    public RuleDatabase(
        IUnitRepository units,
        IBandRepository bands,
        IArmorRepository armors,
        IRangeWeaponRepository rangeWeapons,
        ICloseCombatWeaponRepository closeCombatWeapons,
        IWeaponSpecialRuleRepository specialRules
        )
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
}