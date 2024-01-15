using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Entities.SpecialRules;

namespace RuleEntities;

public class RuleContext : DbContext
{
    public DbSet<ArmorEntity> Armors { get; set; } = null!;

    public DbSet<BandEntity> Bands { get; set; } = null!;

    public DbSet<BandSpecialRuleEntity> BandSpecialRules { get; set; } = null!;

    public DbSet<CloseCombatWeaponEntity> CloseCombatWeapons { get; set; } = null!;

    public DbSet<RangeWeaponEntity> RangeWeapons { get; set; } = null!;

    public DbSet<UnitEntity> Units { get; set; } = null!;
}