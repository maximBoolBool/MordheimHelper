using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Entities.SpecialRules;
using RuleEntities.Models;
using SharedServices.Repositories;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IWeaponSpecialRuleRepository"/>
public class WeaponSpecialRuleRepository 
    : BaseRepositiry<CloseCombatWeaponSpecialRuleEntity, WeaponSpecialRuleFilter>, IWeaponSpecialRuleRepository
{
    public WeaponSpecialRuleRepository(DbContext db) : base(db) { }
}