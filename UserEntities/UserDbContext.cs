using Microsoft.EntityFrameworkCore;
using UserEntities.Entities;

namespace UserEntities;

/// <summary>
///     Контекст для работы с реляционной бд
/// </summary>
public class UserDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; } = null!;

    public DbSet<BandEntity> Bands { get; set; } = null!;

    public DbSet<UnitEntity> Units { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("");
        base.OnConfiguring(optionsBuilder);
    }
}