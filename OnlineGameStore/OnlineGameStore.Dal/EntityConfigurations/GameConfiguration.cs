using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineGameStore.Dal.Entities;

namespace OnlineGameStore.Dal.EntityConfigurations;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.HasKey(g => g.Id);

        builder.Property(g => g.Name)
            .IsRequired()
            .HasMaxLength(100);

       builder.Property(g => g.Key)
        .IsRequired(true)
        .HasMaxLength(100);

        builder.Property(g => g.Description)
        .IsRequired(true)
        .HasMaxLength(100);

        builder.HasMany(gg => gg.GameGenres)
            .WithOne(g => g.Game)
            .HasForeignKey(gg => gg.GameId);

        builder.HasMany(gp => gp.GamePlatforms)
            .WithOne(g => g.Game)
            .HasForeignKey(gp => gp.GameId);
    }
}
