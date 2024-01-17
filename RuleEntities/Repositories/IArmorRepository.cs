using RuleEntities.Entities;
using RuleEntities.Models;
using SharedServices;

namespace RuleEntities.Repositories;

/// <summary>
///     Репозиторий для брони
/// </summary>
public interface IArmorRepository : IRepository<ArmorEntity, ArmorFilter>
{
    
}