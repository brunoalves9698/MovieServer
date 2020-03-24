using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieService.Domain.Entities;

namespace MovieService.Infra.Contexts.Maps
{
    public class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);

            builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnType("varchar(100)");

            builder.Property(x => x.Duration)
               .IsRequired()
               .HasColumnType("time(7)");

            builder.Property(x => x.Rating)
               .IsRequired()
               .HasColumnType("int");

            builder.Property(x => x.Genre)
              .IsRequired()
              .HasColumnType("int");

            builder.Property(x => x.Nationality)
             .IsRequired()
             .HasColumnType("int");

            builder.Property(x => x.Distributor)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(100)");

            builder.Property(x => x.Director)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(100)");

            builder.Property(x => x.Cast)
              .IsRequired()
              .HasMaxLength(400)
              .HasColumnType("varchar(400)");

            builder.Property(x => x.Sinopse)
              .IsRequired()
              .HasMaxLength(800)
              .HasColumnType("varchar(800)");

            builder.Property(x => x.Trailer)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(200)");

            builder.Property(x => x.PortraitImage)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(200)");

            builder.Property(x => x.LandscapeImage)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar(200)");

            builder.Property(x => x.ReleaseDate)
              .IsRequired()
              .HasColumnType("date");

        }
    }
}
