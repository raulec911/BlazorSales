﻿// <auto-generated />
using BlazorSales.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorSales.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230724001924_AddStatesAndCitiesRows")]
    partial class AddStatesAndCitiesRows
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorSales.Shared.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId", "Name")
                        .IsUnique();

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Medellín",
                            StateId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Itagüí",
                            StateId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Envigado",
                            StateId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bello",
                            StateId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Rionegro",
                            StateId = 1
                        },
                        new
                        {
                            Id = 6,
                            Name = "Usaquen",
                            StateId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Champinero",
                            StateId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Santa fe",
                            StateId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "Useme",
                            StateId = 2
                        },
                        new
                        {
                            Id = 10,
                            Name = "Bosa",
                            StateId = 2
                        },
                        new
                        {
                            Id = 11,
                            Name = "Orlando",
                            StateId = 3
                        },
                        new
                        {
                            Id = 12,
                            Name = "Miami",
                            StateId = 3
                        },
                        new
                        {
                            Id = 13,
                            Name = "Tampa",
                            StateId = 3
                        },
                        new
                        {
                            Id = 14,
                            Name = "Fort Lauderdale",
                            StateId = 3
                        },
                        new
                        {
                            Id = 15,
                            Name = "Key West",
                            StateId = 3
                        },
                        new
                        {
                            Id = 16,
                            Name = "Houston",
                            StateId = 4
                        },
                        new
                        {
                            Id = 17,
                            Name = "San Antonio",
                            StateId = 4
                        },
                        new
                        {
                            Id = 18,
                            Name = "Dallas",
                            StateId = 4
                        },
                        new
                        {
                            Id = 19,
                            Name = "Austin",
                            StateId = 4
                        },
                        new
                        {
                            Id = 20,
                            Name = "El Paso",
                            StateId = 4
                        });
                });

            modelBuilder.Entity("BlazorSales.Shared.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Colombia"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Estados Unidos"
                        });
                });

            modelBuilder.Entity("BlazorSales.Shared.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId", "Name")
                        .IsUnique();

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Antioquia"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Bogotá"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 2,
                            Name = "Florida"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            Name = "Texas"
                        });
                });

            modelBuilder.Entity("BlazorSales.Shared.Entities.City", b =>
                {
                    b.HasOne("BlazorSales.Shared.Entities.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("BlazorSales.Shared.Entities.State", b =>
                {
                    b.HasOne("BlazorSales.Shared.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BlazorSales.Shared.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("BlazorSales.Shared.Entities.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
