using Microsoft.EntityFrameworkCore;
using RuleEntities.Entities;
using RuleEntities.Entities.SpecialRules;

namespace RuleEntities;

public class RuleDbContext : DbContext
{
    #region .ctor

    public RuleDbContext() : base() { }

    public RuleDbContext(DbContextOptions<RuleDbContext> options) : base(options) { }
    
    #endregion

    #region Ovverides

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=rule_db;Username=postgres;Password=panzer117");
        base.OnConfiguring(optionsBuilder);
    }    

    #endregion
    
    #region Tables

    public DbSet<ArmorEntity> Armors { get; set; } = null!;

    public DbSet<BandEntity> Bands { get; set; } = null!;

    public DbSet<BandSpecialRuleEntity> BandSpecialRules { get; set; } = null!;

    public DbSet<CloseCombatWeaponEntity> CloseCombatWeapons { get; set; } = null!;

    public DbSet<RangeWeaponEntity> RangeWeapons { get; set; } = null!;

    public DbSet<UnitEntity> Units { get; set; } = null!;
    
    #endregion
}