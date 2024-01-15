using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Entities.SpecialRules;
using UserEntities.Repositories;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IUnitWeaponSpecialRuleRepository"/>
public class UnitWeaponSpecialRuleRepository : BaseRepositiry<CloseCombatWeaponSpecialRuleEntity>, IUnitWeaponSpecialRuleRepository
{
    public UnitWeaponSpecialRuleRepository(DbContext db) : base(db) { }
}