using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Models;
using SharedServices.Repositories;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IUnitRepository"/>
public class UnitRepository : BaseRepositiry<UnitEntity, UnitFilter>, IUnitRepository
{
    public UnitRepository(DbContext db) : base(db) { }
}