
using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Models;
using SharedServices.Repositories;
using SharedServices.Repositories.Impl;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IRangeWeaponRepository"/>
public class RangeWeaponRepository : BaseRepositiry<RangeWeaponEntity, RangeWeaponFilter>, IRangeWeaponRepository
{
    public RangeWeaponRepository(DbContext db) : base(db) { }
}