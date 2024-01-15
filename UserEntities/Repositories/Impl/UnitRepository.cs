using Microsoft.EntityFrameworkCore;
using UserEntities.Entities;

namespace UserEntities.Repositories.Impl;

/// <inheritdoc cref="IUnitRepository"/>
internal class UnitRepository : BaseRepositiry<UnitEntity>, IUnitRepository 
{
    public UnitRepository(DbContext dbContext) : base(dbContext) { }
}