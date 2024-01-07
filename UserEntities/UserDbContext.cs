using Microsoft.EntityFrameworkCore;
using UserEntities.Entities;

namespace UserEntities;

public class UserDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; } = null!;

    public DbSet<BandEntity> Bands { get; set; } = null!;

    public DbSet<UnitEntity> Units { get; set; } = null!;

}