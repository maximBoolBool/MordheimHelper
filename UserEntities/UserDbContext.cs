using Microsoft.EntityFrameworkCore;
using UserEntities.Entities;

namespace UserEntities;

/// <summary>
///     Контекст для работы с реляционной бд
/// </summary>
public class UserDbContext : DbContext
{
    #region .ctor
    
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
    
    #endregion

    #region Tables

    public DbSet<UserEntity> Users { get; set; } = null!;

    public DbSet<BandEntity> Bands { get; set; } = null!;

    public DbSet<UnitEntity> Units { get; set; } = null!;
    
    #endregion

    #region Overrides
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Database.Migrate();
        base.OnConfiguring(optionsBuilder);
    }
    
    #endregion

}