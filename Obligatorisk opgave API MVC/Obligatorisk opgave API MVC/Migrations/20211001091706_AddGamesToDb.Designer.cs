﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Obligatorisk_opgave_API_MVC.Models;

namespace Obligatorisk_opgave_API_MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211001091706_AddGamesToDb")]
    partial class AddGamesToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Obligatorisk_opgave_API_MVC.Games", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dealID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dealRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gameID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("internalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isOnSale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("lastChange")
                        .HasColumnType("int");

                    b.Property<string>("metacriticlink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("metacriticscore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("normalPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("releaseDate")
                        .HasColumnType("int");

                    b.Property<string>("salePrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("savings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("steamAppID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("steamRatingCount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("steamRatingPercent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("steamRatingText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("storeID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thumb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Game");
                });
#pragma warning restore 612, 618
        }
    }
}
