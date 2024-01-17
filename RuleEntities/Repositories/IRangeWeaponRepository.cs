using RuleEntities.Entities;
using RuleEntities.Models;
using SharedServices;

namespace RuleEntities.Repositories;

/// <summary>
///     Репозиторий для работы с дальнего боя 
/// </summary>
public interface IRangeWeaponRepository : IRepository<RangeWeaponEntity, RangeWeaponFilter>
{
    
}