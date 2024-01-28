
using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Models;
using SharedServices.Repositories;
using SharedServices.Repositories.Impl;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="ICloseCombatWeaponRepository"/>
public class CloseCombatWeaponRepository : 
    BaseRepositiry<CloseCombatWeaponEntity, CloseCombatFilter> , ICloseCombatWeaponRepository
{
    public CloseCombatWeaponRepository(DbContext db) : base(db) { }
}