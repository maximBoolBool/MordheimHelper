using Microsoft.EntityFrameworkCore;
using SharedServices.Repositories;
using SharedServices.Repositories.Impl;
using UserEntities.Entities;
using UserEntities.Models;

namespace UserEntities.Repositories.Impl;

/// <inheritdoc cref="IUnitRepository"/>
internal class UnitRepository : BaseRepositiry<UnitEntity, UnitFilter>, IUnitRepository 
{
    public UnitRepository(DbContext dbContext) : base(dbContext) { }
}