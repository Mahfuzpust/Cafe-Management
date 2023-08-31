﻿// <auto-generated />
using Cafe.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cafe.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cafe.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Mercedes"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Ferrari"
                        });
                });

            modelBuilder.Entity("Cafe.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.",
                            FoodCode = "SWB012345698",
                            FoodName = "Pizza",
                            ListPrice = 200.0,
                            Price = 180.0,
                            Price100 = 130.0,
                            Price50 = 160.0,
                            Title = "The New Food Village"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.",
                            FoodCode = "SWB012345698",
                            FoodName = "Pasta",
                            ListPrice = 300.0,
                            Price = 250.0,
                            Price100 = 200.0,
                            Price50 = 220.0,
                            Title = "The Pasta"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.",
                            FoodCode = "SWB012345698",
                            FoodName = "New Cabab",
                            ListPrice = 320.0,
                            Price = 300.0,
                            Price100 = 250.0,
                            Price50 = 280.0,
                            Title = "Cabab"
                        });
                });

            modelBuilder.Entity("Cafe.Models.Product", b =>
                {
                    b.HasOne("Cafe.Models.Category", "Category")
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
