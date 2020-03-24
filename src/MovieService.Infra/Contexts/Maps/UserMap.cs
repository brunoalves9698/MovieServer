using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieService.Domain.Entities;

namespace MovieService.Infra.Contexts.Maps
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);

            builder.OwnsOne(x => x.Name, name =>
            {
                name.Property(x => x.FirstNameProperty)
                    .IsRequired()
                    .HasColumnName("FirstName")
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                name.Property(x => x.LastNameProperty)
                    .IsRequired()
                    .HasColumnName("LastName")
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");
            });

            builder.OwnsOne(x => x.Document, document =>
            {
                document.Property(x => x.DocumentProperty)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasMaxLength(11)
                    .HasColumnType("char(11)");
            });

            builder.Property(x => x.Gender)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(x => x.BirthDate)
               .IsRequired()
               .HasColumnType("date");
            
            builder.OwnsOne(x => x.Email, email =>
            {
                email.Property(x => x.EmailProperty)
                   .IsRequired()
                   .HasColumnName("Email")
                   .HasMaxLength(200)
                   .HasColumnType("varchar(200)");
            });

            builder.OwnsOne(x => x.Phone, phone =>
            {
                phone.Property(x => x.PhoneProperty)
                    .IsRequired()
                    .HasColumnName("Phone")
                    .HasMaxLength(11)
                    .HasColumnType("varchar(11)");
            });

            builder.OwnsOne(x => x.Address, address =>
            {
                address.Property(x => x.StreetProperty)
                    .HasColumnName("Street")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                address.Property(x => x.NumberProperty)
                    .HasColumnName("Number")
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnType("varchar(10)");

                address.Property(x => x.NeighborhoodProperty)
                    .HasColumnName("Neighborhood")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                address.Property(x => x.CityProperty)
                    .HasColumnName("City")
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnType("varchar(80)");

                address.Property(x => x.StateProperty)
                    .HasColumnName("State")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                address.Property(x => x.CountryProperty)
                    .HasColumnName("Country")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                address.Property(x => x.ZipCodeProperty)
                    .HasColumnName("ZipCode")
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnType("char(8)");
            });
        }
    }
}
