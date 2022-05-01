﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Personal_Inventory.Data;

#nullable disable

namespace Personal_Inventory.Migrations
{
    [DbContext(typeof(Personal_InventoryContext))]
    partial class Personal_InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Personal_Inventory.Models.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("Personal_Inventory.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Personal_Inventory.Models.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEntered")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int>("SubCategoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("Personal_Inventory.Models.InventoryView", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEntered")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int>("SubCategoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("InventoryView");
                });

            modelBuilder.Entity("Personal_Inventory.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
