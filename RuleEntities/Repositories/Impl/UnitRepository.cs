using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using UserEntities.Repositories;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IUnitRepository"/>
public class UnitRepository : BaseRepositiry<UnitEntity>, IUnitRepository
{
    public UnitRepository(DbContext db) : base(db) { }
}