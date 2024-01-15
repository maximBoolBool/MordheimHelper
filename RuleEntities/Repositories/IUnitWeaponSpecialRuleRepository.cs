using RuleEntities.Entities;
using RuleEntities.Entities.SpecialRules;
using SharedServices;

namespace RuleEntities.Repositories;

/// <summary>
///     Репозиторий для работы со спец правилами оружия
/// </summary>
public interface IUnitWeaponSpecialRuleRepository : IRepository<CloseCombatWeaponSpecialRuleEntity>
{
    
}