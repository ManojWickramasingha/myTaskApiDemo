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
    [Migration("20240603140242_AdminGmailremove")]
    partial class AdminGmailremove
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Adminid");

                    b.HasIndex("UserId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Adminid = 1,
                            Amount = 3000.0,
                            Description = "Get some text books for school",
                            Due = new DateTime(2024, 6, 8, 19, 32, 41, 125, DateTimeKind.Local).AddTicks(33),
                            UserId = 100,
                            created = new DateTime(2024, 6, 3, 19, 32, 41, 124, DateTimeKind.Local).AddTicks(9261),
                            status = 0,
                            title = "Expense Tax record in database"
                        },
                        new
                        {
                            id = 2,
                            Adminid = 2,
                            Amount = 3890.0,
                            Description = "Goverment Tax Added water bill",
                            Due = new DateTime(2024, 6, 8, 19, 32, 41, 125, DateTimeKind.Local).AddTicks(3479),
                            UserId = 101,
                            created = new DateTime(2024, 6, 3, 19, 32, 41, 125, DateTimeKind.Local).AddTicks(3467),
                            status = 0,
                            title = "Expense For Water bill"
                        },
                        new
                        {
                            id = 3,
                            Adminid = 1,
                            Amount = 3780.0,
                            Description = "Goverment Tax Added current bill",
                            Due = new DateTime(2024, 6, 8, 19, 32, 41, 125, DateTimeKind.Local).AddTicks(3505),
                            UserId = 102,
                            created = new DateTime(2024, 6, 3, 19, 32, 41, 125, DateTimeKind.Local).AddTicks(3502),
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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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

            modelBuilder.Entity("myTaskApi.Models.EBudget", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("id");

                    b.ToTable("EBudgets");

                    b.HasData(
                        new
                        {
                            id = "c00B",
                            Amount = 5000.0,
                            Description = "Education manthly Budget Limit"
                        },
                        new
                        {
                            id = "c01B",
                            Amount = 45000.0,
                            Description = "Medical budgets"
                        });
                });

            modelBuilder.Entity("myTaskApi.Models.Income", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("Categories")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Incomes");

                    b.HasData(
                        new
                        {
                            Id = "c001",
                            Amount = 450.0,
                            Categories = "Utility Income",
                            UserId = 100,
                            description = "receive bording fees",
                            start = new DateTime(2024, 6, 3, 19, 32, 41, 121, DateTimeKind.Local).AddTicks(8179)
                        },
                        new
                        {
                            Id = "c002",
                            Amount = 450.0,
                            Categories = "Salary",
                            UserId = 102,
                            description = "receive monthly salary",
                            start = new DateTime(2024, 6, 3, 19, 32, 41, 124, DateTimeKind.Local).AddTicks(2555)
                        });
                });

            modelBuilder.Entity("myTaskApi.Models.Saving", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Savings");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            Amount = 400.0,
                            Description = "Saving montlty utility Income",
                            Name = "manoj",
                            UserId = 100
                        },
                        new
                        {
                            Id = 12,
                            Amount = 5000.5,
                            Description = "Saving Salary",
                            Name = "Lahiru",
                            UserId = 101
                        });
                });

            modelBuilder.Entity("myTaskApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AddressNo")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            AddressNo = 45,
                            City = "Colombo",
                            Gmail = "wicmanoj@gmail.com",
                            Name = "manoj",
                            Password = "manoj@123",
                            Street = "Lake round"
                        },
                        new
                        {
                            Id = 101,
                            AddressNo = 50,
                            City = "Nugegoda",
                            Gmail = "Menaka@gmail.com",
                            Name = "Menaka",
                            Password = "menaka@123",
                            Street = "Charls road"
                        },
                        new
                        {
                            Id = 102,
                            AddressNo = 121,
                            City = "Kadawatha",
                            Gmail = "Ashen@gmail.com",
                            Name = "Ashen",
                            Password = "Ashen@123",
                            Street = "Pilip road"
                        },
                        new
                        {
                            Id = 103,
                            AddressNo = 30,
                            City = "Colombo",
                            Gmail = "Chinthaka@gmail.com",
                            Name = "Chinthaka",
                            Password = "Chinthaka@123",
                            Street = "Lotus"
                        });
                });

            modelBuilder.Entity("myTaskApi.Model.Expense", b =>
                {
                    b.HasOne("myTaskApi.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("Adminid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myTaskApi.Models.User", "User")
                        .WithMany("Expenses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("User");
                });

            modelBuilder.Entity("myTaskApi.Models.Income", b =>
                {
                    b.HasOne("myTaskApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("myTaskApi.Models.Saving", b =>
                {
                    b.HasOne("myTaskApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("myTaskApi.Models.User", b =>
                {
                    b.Navigation("Expenses");
                });
#pragma warning restore 612, 618
        }
    }
}
