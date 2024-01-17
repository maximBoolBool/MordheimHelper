using RuleEntities.Entities;
using RuleEntities.Models;
using SharedServices;

namespace RuleEntities.Repositories;

/// <summary>
///     Репозиторий для работы с бандами
/// </summary>
public interface IBandRepository : IRepository<BandEntity, BandFilter>
{
    
}