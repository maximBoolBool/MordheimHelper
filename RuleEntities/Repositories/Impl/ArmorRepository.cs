using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Models;
using SharedServices.Repositories;
using SharedServices.Repositories.Impl;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IArmorRepository"/>
internal class ArmorRepository : BaseRepositiry<ArmorEntity, ArmorFilter>, IArmorRepository
{
    public ArmorRepository(DbContext db) : base(db) { }
}