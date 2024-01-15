using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Entities.SpecialRules;
using UserEntities.Repositories;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IBandSpecialRuleRepository"/>
public class BandSpeicalRuleRepository : BaseRepositiry<BandSpecialRuleEntity> , IBandSpecialRuleRepository
{
    public BandSpeicalRuleRepository(DbContext db) : base(db) { }
}