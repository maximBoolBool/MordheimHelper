using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Entities.SpecialRules;
using RuleEntities.Models;
using SharedServices.Repositories;
using SharedServices.Repositories.Impl;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IBandSpecialRuleRepository"/>
public class BandSpeicalRuleRepository : BaseRepositiry<BandSpecialRuleEntity, BandSpecialRuleFilter> , IBandSpecialRuleRepository
{
    public BandSpeicalRuleRepository(DbContext db) : base(db) { }
}