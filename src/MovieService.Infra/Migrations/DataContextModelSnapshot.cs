﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieService.Infra.Contexts;

namespace MovieService.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieService.Domain.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("MovieService.Domain.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cast")
                        .IsRequired()
                        .HasColumnType("varchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Distributor")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time(7)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("LandscapeImage")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Nationality")
                        .HasColumnType("int");

                    b.Property<string>("PortraitImage")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(100);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasColumnType("varchar(800)")
                        .HasMaxLength(800);

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MovieService.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MovieService.Domain.Entities.Account", b =>
                {
                    b.OwnsOne("MovieService.Domain.ValueObjects.Email", "UserName", b1 =>
                        {
                            b1.Property<Guid>("AccountId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("EmailProperty")
                                .IsRequired()
                                .HasColumnName("UserName")
                                .HasColumnType("varchar(200)")
                                .HasMaxLength(200);

                            b1.HasKey("AccountId");

                            b1.ToTable("Account");

                            b1.WithOwner()
                                .HasForeignKey("AccountId");
                        });
                });

            modelBuilder.Entity("MovieService.Domain.Entities.User", b =>
                {
                    b.OwnsOne("MovieService.Domain.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("CityProperty")
                                .IsRequired()
                                .HasColumnName("City")
                                .HasColumnType("varchar(80)")
                                .HasMaxLength(80);

                            b1.Property<string>("CountryProperty")
                                .IsRequired()
                                .HasColumnName("Country")
                                .HasColumnType("varchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("NeighborhoodProperty")
                                .IsRequired()
                                .HasColumnName("Neighborhood")
                                .HasColumnType("varchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("NumberProperty")
                                .IsRequired()
                                .HasColumnName("Number")
                                .HasColumnType("varchar(10)")
                                .HasMaxLength(10);

                            b1.Property<string>("StateProperty")
                                .IsRequired()
                                .HasColumnName("State")
                                .HasColumnType("varchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("StreetProperty")
                                .IsRequired()
                                .HasColumnName("Street")
                                .HasColumnType("varchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("ZipCodeProperty")
                                .IsRequired()
                                .HasColumnName("ZipCode")
                                .HasColumnType("char(8)")
                                .HasMaxLength(8);

                            b1.HasKey("UserId");

                            b1.ToTable("User");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("MovieService.Domain.ValueObjects.Document", "Document", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("DocumentProperty")
                                .IsRequired()
                                .HasColumnName("CPF")
                                .HasColumnType("char(11)")
                                .HasMaxLength(11);

                            b1.HasKey("UserId");

                            b1.ToTable("User");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("MovieService.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("EmailProperty")
                                .IsRequired()
                                .HasColumnName("Email")
                                .HasColumnType("varchar(200)")
                                .HasMaxLength(200);

                            b1.HasKey("UserId");

                            b1.ToTable("User");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("MovieService.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("FirstNameProperty")
                                .IsRequired()
                                .HasColumnName("FirstName")
                                .HasColumnType("varchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("LastNameProperty")
                                .IsRequired()
                                .HasColumnName("LastName")
                                .HasColumnType("varchar(50)")
                                .HasMaxLength(50);

                            b1.HasKey("UserId");

                            b1.ToTable("User");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("MovieService.Domain.ValueObjects.Phone", "Phone", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("PhoneProperty")
                                .IsRequired()
                                .HasColumnName("Phone")
                                .HasColumnType("varchar(11)")
                                .HasMaxLength(11);

                            b1.HasKey("UserId");

                            b1.ToTable("User");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
