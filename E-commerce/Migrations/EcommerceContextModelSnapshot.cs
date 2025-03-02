﻿// <auto-generated />
using E_commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_commerce.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    partial class EcommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_commerce.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<int>("productid")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("id")
                        .HasName("PK__Cart__3213E83F247AE08F");

                    b.HasIndex("productid");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("E_commerce.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id")
                        .HasName("PK__Category__3213E83F9F4F1D7D");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("E_commerce.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("catid")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("id")
                        .HasName("PK__Product__3213E83F3E49E8EC");

                    b.HasIndex("catid");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("E_commerce.Models.Review", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("subject")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id")
                        .HasName("PK__Review__3213E83F44C5A239");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("E_commerce.Models.Cart", b =>
                {
                    b.HasOne("E_commerce.Models.Product", "product")
                        .WithMany("Carts")
                        .HasForeignKey("productid")
                        .IsRequired()
                        .HasConstraintName("FK__Cart__productid__3E52440B");

                    b.Navigation("product");
                });

            modelBuilder.Entity("E_commerce.Models.Product", b =>
                {
                    b.HasOne("E_commerce.Models.Category", "cat")
                        .WithMany("Products")
                        .HasForeignKey("catid")
                        .HasConstraintName("FK__Product__catid__398D8EEE");

                    b.Navigation("cat");
                });

            modelBuilder.Entity("E_commerce.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_commerce.Models.Product", b =>
                {
                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}
