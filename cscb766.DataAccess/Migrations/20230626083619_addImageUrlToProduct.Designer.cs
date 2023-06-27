﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cscb766.DataAccess.Data;

#nullable disable

namespace cscb766.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230626083619_addImageUrlToProduct")]
    partial class addImageUrlToProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cscb766.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        });
                });

            modelBuilder.Entity("cscb766.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountPrice")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Ben's Original",
                            CategoryId = 1,
                            Description = "Savor the delicious taste of traditional Thai Jasmine rice and satisfy your desire for Southeast Asian cuisine in just 90 seconds.",
                            DiscountPrice = 4.9900000000000002,
                            ImageUrl = "",
                            ListPrice = 5.4500000000000002,
                            Name = "Microwave Rice"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Lindt",
                            CategoryId = 1,
                            Description = "Discover our classic LINDOR Milk Chocolate Truffles. Since 1845, the Lindt Master Chocolatiers have combined their expertise with the highest quality ingredients from around the world to produce the finest chocolates.",
                            DiscountPrice = 7.5,
                            ImageUrl = "",
                            ListPrice = 9.5,
                            Name = "Milk Chocolate Truffles"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Olympus",
                            CategoryId = 2,
                            Description = "Olympus fresh milk, produced from fresh milk carefully selected from selected farms, is the excellent choice for a brisk morning.",
                            DiscountPrice = 2.5,
                            ImageUrl = "",
                            ListPrice = 3.2999999999999998,
                            Name = "Milk"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Gradus",
                            CategoryId = 2,
                            Description = "Fresh chicken is suitable for grilling, in the oven, boiling and making delicious soup. Without added water, preservatives and phosphates.",
                            DiscountPrice = 8.0999999999999996,
                            ImageUrl = "",
                            ListPrice = 8.8000000000000007,
                            Name = "Whole chicken"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Crunchips",
                            CategoryId = 2,
                            Description = "Curly potato chips with barbecue flavor.",
                            DiscountPrice = 2.7999999999999998,
                            ImageUrl = "",
                            ListPrice = 3.0,
                            Name = "Chips"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Estrella",
                            CategoryId = 1,
                            Description = "The beer of Barcelona",
                            DiscountPrice = 2.2000000000000002,
                            ImageUrl = "",
                            ListPrice = 2.7999999999999998,
                            Name = "Corona Estrella"
                        });
                });

            modelBuilder.Entity("cscb766.Models.Product", b =>
                {
                    b.HasOne("cscb766.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}