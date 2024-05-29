﻿// <auto-generated />
using System;
using Hotels.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotels.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240529155434_AddDiscountToBookEntity")]
    partial class AddDiscountToBookEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hotels.Models.Book", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BranchId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("money");

                    b.Property<int>("discount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Hotels.Models.Branch", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = "a2e5385b-1c9a-4e98-8198-f62096375960",
                            Address = "NorthCoast Address",
                            Name = "NorthCoast"
                        },
                        new
                        {
                            Id = "b109b21e-2763-4b41-9d9b-9192fa1aebd1",
                            Address = "Alexandria Address",
                            Name = "Alexandria"
                        },
                        new
                        {
                            Id = "9ccf64c0-2a17-46e6-9ac1-feed42000048",
                            Address = "Hurgada Address",
                            Name = "Hurgada"
                        });
                });

            modelBuilder.Entity("Hotels.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Hotels.Models.Room", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AdultsNumber")
                        .HasColumnType("int");

                    b.Property<string>("BookId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ChildrenNumber")
                        .HasColumnType("int");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Hotels.Models.Book", b =>
                {
                    b.HasOne("Hotels.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotels.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Hotels.Models.Room", b =>
                {
                    b.HasOne("Hotels.Models.Book", "Book")
                        .WithMany("Rooms")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Hotels.Models.Book", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
