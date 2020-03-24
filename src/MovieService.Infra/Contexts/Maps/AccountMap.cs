using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieService.Domain.Entities;

namespace MovieService.Infra.Contexts.Maps
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);

            builder.OwnsOne(x => x.UserName, userName =>
            {
                userName.Property(x => x.EmailProperty)
                   .IsRequired()
                   .HasColumnName("UserName")
                   .HasMaxLength(200)
                   .HasColumnType("varchar(200)");
            });

            builder.Property(x => x.Password)
               .IsRequired()
               .HasMaxLength(200)
               .HasColumnType("varchar(200)");

            builder.Property(x => x.Role)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnType("varchar(50)");
        }
    }
}
