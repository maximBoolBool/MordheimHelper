using RuleEntities.Entities.SpecialRules;
using RuleEntities.Models;
using SharedServices;

namespace RuleEntities.Repositories;

/// <summary>
///     Репозиторий для работы со спец правилами оружия
/// </summary>
public interface IWeaponSpecialRuleRepository : IRepository<CloseCombatWeaponSpecialRuleEntity, CloseCombatFilter> { }