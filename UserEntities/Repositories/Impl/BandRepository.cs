using Microsoft.EntityFrameworkCore;
using UserEntities.Entities;

namespace UserEntities.Repositories.Impl;

/// <inheritdoc cref="IBandRepository"/>
internal class BandRepository : BaseRepositiry<BandEntity> , IBandRepository
{
    /// <inheritdoc cref="IBandRepository"/>
    public BandRepository(DbContext dbContext) : base(dbContext) { }
}