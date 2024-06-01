﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myTaskApi.DataAccess;

namespace myTaskApi.DataAccess.Migrations
{
    [DbContext(typeof(ExpenseDbContext))]
    [Migration("20240601082436_IncomeData")]
    partial class IncomeData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("myTaskApi.Model.Expense", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Adminid")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Adminid");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Adminid = 1,
                            Amount = 3000.0,
                            Description = "Get some text books for school",
                            Due = new DateTime(2024, 6, 6, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(4230),
                            created = new DateTime(2024, 6, 1, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(3954),
                            status = 0,
                            title = "Expense Tax record in database"
                        },
                        new
                        {
                            id = 2,
                            Adminid = 2,
                            Amount = 3890.0,
                            Description = "Goverment Tax Added water bill",
                            Due = new DateTime(2024, 6, 6, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(5261),
                            created = new DateTime(2024, 6, 1, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(5256),
                            status = 0,
                            title = "Expense For Water bill"
                        },
                        new
                        {
                            id = 3,
                            Adminid = 1,
                            Amount = 3780.0,
                            Description = "Goverment Tax Added current bill",
                            Due = new DateTime(2024, 6, 6, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(5269),
                            created = new DateTime(2024, 6, 1, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(5268),
                            status = 0,
                            title = "Expense For Current bill"
                        });
                });

            modelBuilder.Entity("myTaskApi.Models.Admin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            id = 1,
                            name = "manoj"
                        },
                        new
                        {
                            id = 2,
                            name = "Lahiru"
                        },
                        new
                        {
                            id = 3,
                            name = "kasun"
                        },
                        new
                        {
                            id = 4,
                            name = "malindu"
                        },
                        new
                        {
                            id = 5,
                            name = "Amila"
                        });
                });

            modelBuilder.Entity("myTaskApi.Models.Income", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("Categories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Incomes");

                    b.HasData(
                        new
                        {
                            Id = "c001",
                            Amount = 450.0,
                            Categories = "Utility Income",
                            description = "receive bording fees",
                            start = new DateTime(2024, 6, 1, 13, 54, 36, 475, DateTimeKind.Local).AddTicks(2459)
                        },
                        new
                        {
                            Id = "c002",
                            Amount = 450.0,
                            Categories = "Salary",
                            description = "receive monthly salary",
                            start = new DateTime(2024, 6, 1, 13, 54, 36, 476, DateTimeKind.Local).AddTicks(2535)
                        });
                });

            modelBuilder.Entity("myTaskApi.Model.Expense", b =>
                {
                    b.HasOne("myTaskApi.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("Adminid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });
#pragma warning restore 612, 618
        }
    }
}
