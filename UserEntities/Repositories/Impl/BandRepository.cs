using Microsoft.EntityFrameworkCore;
using SharedServices.Repositories;
using SharedServices.Repositories.Impl;
using UserEntities.Entities;
using UserEntities.Models;

namespace UserEntities.Repositories.Impl;

/// <inheritdoc cref="IBandRepository"/>
internal class BandRepository : BaseRepositiry<BandEntity, BandFilter> , IBandRepository
{
    /// <inheritdoc cref="IBandRepository"/>
    public BandRepository(DbContext dbContext) : base(dbContext) { }
}