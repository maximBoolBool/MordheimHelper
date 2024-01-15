
using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using UserEntities.Repositories;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="ICloseCombatWeaponRepository"/>
public class CloseCombatWeaponRepository : 
    BaseRepositiry<CloseCombatWeaponEntity> , ICloseCombatWeaponRepository
{
    public CloseCombatWeaponRepository(DbContext db) : base(db) { }
}