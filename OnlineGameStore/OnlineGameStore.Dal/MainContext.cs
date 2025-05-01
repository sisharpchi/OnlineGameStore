using Microsoft.EntityFrameworkCore;
using OnlineGameStore.Dal.Entities;
using OnlineGameStore.Dal.EntityConfigurations;

namespace OnlineGameStore.Dal;

public class MainContext : DbContext
{
    public DbSet<Game> Games { get; set; }
    public DbSet<GameGenre> GameGenres { get; set; }
    public DbSet<GamePlatform> GamePlatforms { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Platform> Platforms { get; set; }

    public MainContext(DbContextOptions options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GameConfiguration());
        modelBuilder.ApplyConfiguration(new GenreConfiguration());
        modelBuilder.ApplyConfiguration(new GameGenreConfiguration());
        modelBuilder.ApplyConfiguration(new PlatformConfiguration());
        modelBuilder.ApplyConfiguration(new GamePlatformConfiguration());
    }
}
