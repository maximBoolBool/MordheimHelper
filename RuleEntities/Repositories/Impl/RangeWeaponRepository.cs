
using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using UserEntities.Repositories;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IRangeWeaponRepository"/>
public class RangeWeaponRepository : BaseRepositiry<RangeWeaponEntity>, IRangeWeaponRepository
{
    public RangeWeaponRepository(DbContext db) : base(db) { }
}