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
    [Migration("20240603070134_addConstraint")]
    partial class addConstraint
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
                            Due = new DateTime(2024, 6, 8, 12, 31, 33, 336, DateTimeKind.Local).AddTicks(8854),
                            UserId = 100,
                            created = new DateTime(2024, 6, 3, 12, 31, 33, 336, DateTimeKind.Local).AddTicks(8357),
                            status = 0,
                            title = "Expense Tax record in database"
                        },
                        new
                        {
                            id = 2,
                            Adminid = 2,
                            Amount = 3890.0,
                            Description = "Goverment Tax Added water bill",
                            Due = new DateTime(2024, 6, 8, 12, 31, 33, 337, DateTimeKind.Local).AddTicks(1108),
                            UserId = 101,
                            created = new DateTime(2024, 6, 3, 12, 31, 33, 337, DateTimeKind.Local).AddTicks(1100),
                            status = 0,
                            title = "Expense For Water bill"
                        },
                        new
                        {
                            id = 3,
                            Adminid = 1,
                            Amount = 3780.0,
                            Description = "Goverment Tax Added current bill",
                            Due = new DateTime(2024, 6, 8, 12, 31, 33, 337, DateTimeKind.Local).AddTicks(1124),
                            UserId = 102,
                            created = new DateTime(2024, 6, 3, 12, 31, 33, 337, DateTimeKind.Local).AddTicks(1122),
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

                    b.Property<string>("gmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            id = 1,
                            gmail = "manoj@gmail.com",
                            name = "manoj"
                        },
                        new
                        {
                            id = 2,
                            gmail = "Lahiru@gmai.com",
                            name = "Lahiru"
                        },
                        new
                        {
                            id = 3,
                            gmail = "Kasun@gmail.com",
                            name = "kasun"
                        },
                        new
                        {
                            id = 4,
                            gmail = "malindu@gmail.com",
                            name = "malindu"
                        },
                        new
                        {
                            id = 5,
                            gmail = "Amila@gmail.com",
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
                            start = new DateTime(2024, 6, 3, 12, 31, 33, 334, DateTimeKind.Local).AddTicks(7196)
                        },
                        new
                        {
                            Id = "c002",
                            Amount = 450.0,
                            Categories = "Salary",
                            UserId = 102,
                            description = "receive monthly salary",
                            start = new DateTime(2024, 6, 3, 12, 31, 33, 336, DateTimeKind.Local).AddTicks(3610)
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

                    b.Property<string>("Gmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Gmail = "wicmanoj@gmail.com",
                            Name = "manoj",
                            Password = "manoj@123"
                        },
                        new
                        {
                            Id = 101,
                            Gmail = "Menaka@gmail.com",
                            Name = "Menaka",
                            Password = "menaka@123"
                        },
                        new
                        {
                            Id = 102,
                            Gmail = "Ashen@gmail.com",
                            Name = "Ashen",
                            Password = "Ashen@123"
                        },
                        new
                        {
                            Id = 103,
                            Gmail = "Chinthaka@gmail.com",
                            Name = "Chinthaka",
                            Password = "Chinthaka@123"
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
                        .WithMany()
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
#pragma warning restore 612, 618
        }
    }
}
