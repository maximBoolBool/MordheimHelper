using RuleEntities.Entities;
using RuleEntities.Models;
using SharedServices;

namespace RuleEntities.Repositories;

/// <summary>
///     Репозиторий для работы с юнитами
/// </summary>
public interface IUnitRepository : IRepository<UnitEntity, UnitFilter> { }