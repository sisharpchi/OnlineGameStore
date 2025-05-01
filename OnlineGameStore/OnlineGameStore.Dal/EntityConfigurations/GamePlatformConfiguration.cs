using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineGameStore.Dal.Entities;

namespace OnlineGameStore.Dal.EntityConfigurations;

public class GamePlatformConfiguration : IEntityTypeConfiguration<GamePlatform>
{
    public void Configure(EntityTypeBuilder<GamePlatform> builder)
    {
        builder.HasKey(b => new { b.GameId, b.PlatformId });

        builder.HasOne(b => b.Game)
            .WithMany(t => t.GamePlatforms)
            .HasForeignKey(b => b.GameId);

        builder.HasOne(b => b.Platform)
            .WithMany(t => t.GamePlatforms)
            .HasForeignKey(b => b.PlatformId);
    }
}
