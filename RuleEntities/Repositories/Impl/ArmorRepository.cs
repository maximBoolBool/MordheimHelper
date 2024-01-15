using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using UserEntities.Repositories;

namespace RuleEntities.Repositories.Impl;

/// <inheritdoc cref="IArmorRepository"/>
internal class ArmorRepository : BaseRepositiry<ArmorEntity>, IArmorRepository
{
    public ArmorRepository(DbContext db) : base(db) { }
}