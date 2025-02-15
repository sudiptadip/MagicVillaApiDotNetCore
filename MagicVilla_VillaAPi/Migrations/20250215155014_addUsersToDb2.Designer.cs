﻿// <auto-generated />
using System;
using MagicVilla_VillaAPi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250215155014_addUsersToDb2")]
    partial class addUsersToDb2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPi.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalUsers");
                });

            modelBuilder.Entity("MagicVilla_VillaAPi.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedData")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Pool, Spa, Private Beach",
                            CreatedData = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Luxurious villa with ocean view",
                            ImageUrl = "https://example.com/royal-villa.jpg",
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 500.0,
                            Sqft = 2000,
                            UpdatedData = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Fireplace, Hiking Trails, Hot Tub",
                            CreatedData = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Cozy villa in the mountains",
                            ImageUrl = "https://example.com/mountain-retreat.jpg",
                            Name = "Mountain Retreat",
                            Occupancy = 6,
                            Rate = 350.0,
                            Sqft = 1500,
                            UpdatedData = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Beach Access, BBQ, Surfing Gear",
                            CreatedData = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "A villa near the beautiful beach",
                            ImageUrl = "https://example.com/seaside-escape.jpg",
                            Name = "Seaside Escape",
                            Occupancy = 5,
                            Rate = 450.0,
                            Sqft = 1800,
                            UpdatedData = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Hiking, Wildlife Watching, Fireplace",
                            CreatedData = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Peaceful retreat surrounded by trees",
                            ImageUrl = "https://example.com/forest-haven.jpg",
                            Name = "Forest Haven",
                            Occupancy = 4,
                            Rate = 300.0,
                            Sqft = 1300,
                            UpdatedData = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Infinity Pool, Camel Rides, Private Chef",
                            CreatedData = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "A luxurious stay in the heart of the desert",
                            ImageUrl = "https://example.com/desert-oasis.jpg",
                            Name = "Desert Oasis",
                            Occupancy = 3,
                            Rate = 400.0,
                            Sqft = 1700,
                            UpdatedData = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPi.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("MagicVilla_VillaAPi.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_VillaAPi.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
