using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineGameStore.Dal.Entities;

namespace OnlineGameStore.Dal.EntityConfigurations;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.ToTable("Games");

        builder.HasKey(g => g.Id);

        builder.Property(g => g.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(g => g.Key);
        builder.Property(g => g.Key)
            .IsRequired(true);

        builder.Property(g => g.Description)
            .IsRequired(false)
            .HasMaxLength(255);
    }
}
