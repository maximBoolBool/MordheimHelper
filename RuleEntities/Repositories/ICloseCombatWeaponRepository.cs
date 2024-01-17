using RuleEntities.Entities;
using RuleEntities.Models;
using SharedServices;

namespace RuleEntities.Repositories;

/// <summary>
///     Репозиторий для работы с оржием ближнего боя
/// </summary>
public interface ICloseCombatWeaponRepository : IRepository<CloseCombatWeaponEntity, CloseCombatFilter> { }