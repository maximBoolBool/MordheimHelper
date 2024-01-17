using RuleEntities.Entities;
using RuleEntities.Entities.SpecialRules;
using RuleEntities.Models;
using SharedServices;

namespace RuleEntities.Repositories;

/// <summary>
///     Репозиторий для работы в спец правилами банд
/// </summary>
public interface IBandSpecialRuleRepository : IRepository<BandSpecialRuleEntity, BandSpecialRuleFilter>
{
    
}