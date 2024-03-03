using Microsoft.EntityFrameworkCore;
using UserEntities.Entities;

namespace UserEntities;

/// <summary>
///     Контекст для работы с реляционной бд
/// </summary>
public class UserDbContext : DbContext
{
    #region .ctor
    
    public UserDbContext() : base() { }
    
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
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=userDb;Username=postgres;Password=panzer117");
        base.OnConfiguring(optionsBuilder);
    }
    
    #endregion

}