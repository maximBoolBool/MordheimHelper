using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Models;
using SharedServices.Repositories;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IBandRepository"/>
public class BandRepository : BaseRepositiry<BandEntity, BandFilter>, IBandRepository
{
    public BandRepository(DbContext db) : base(db) { }
}