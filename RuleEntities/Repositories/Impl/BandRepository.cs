using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using UserEntities.Repositories;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IBandRepository"/>
public class BandRepository : BaseRepositiry<BandEntity>, IBandRepository
{
    public BandRepository(DbContext db) : base(db) { }
}