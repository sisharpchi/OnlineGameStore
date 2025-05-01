using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineGameStore.Dal.Entities;

namespace OnlineGameStore.Dal.EntityConfigurations;

public class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(g => g.Name)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasOne(g => g.ParentGenre)
        .WithMany()
        .HasForeignKey(g => g.ParentGenreId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(g => g.GameGenres)
       .WithOne(gg => gg.Genre)
       .HasForeignKey(gg => gg.GenreId);
    }
}
