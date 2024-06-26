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
    [DbContext(typeof(TodoDbContext))]
    [Migration("20240531050937_AuthorEntityData")]
    partial class AuthorEntityData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("myTaskApi.Model.Todo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Authorid")
                        .HasColumnType("int");

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

                    b.HasIndex("Authorid");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            id = 9,
                            Authorid = 1,
                            Description = "Get some text books for school",
                            Due = new DateTime(2024, 6, 2, 10, 39, 36, 956, DateTimeKind.Local).AddTicks(4661),
                            created = new DateTime(2024, 5, 31, 10, 39, 36, 954, DateTimeKind.Local).AddTicks(6941),
                            status = 0,
                            title = "get book for school from DB"
                        },
                        new
                        {
                            id = 1,
                            Authorid = 1,
                            Description = "Get some text books for school",
                            Due = new DateTime(2024, 6, 3, 10, 39, 36, 956, DateTimeKind.Local).AddTicks(7391),
                            created = new DateTime(2024, 5, 31, 10, 39, 36, 956, DateTimeKind.Local).AddTicks(7371),
                            status = 0,
                            title = "get book for school from DB"
                        },
                        new
                        {
                            id = 2,
                            Authorid = 3,
                            Description = "Get some text books for school",
                            Due = new DateTime(2024, 6, 4, 10, 39, 36, 956, DateTimeKind.Local).AddTicks(7413),
                            created = new DateTime(2024, 5, 31, 10, 39, 36, 956, DateTimeKind.Local).AddTicks(7411),
                            status = 0,
                            title = "get person for Expense from DB"
                        });
                });

            modelBuilder.Entity("myTaskApi.Models.Author", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("fullname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            id = 1,
                            fullname = "manoj wickramasingha"
                        },
                        new
                        {
                            id = 2,
                            fullname = "Kasun smaranayaka"
                        },
                        new
                        {
                            id = 3,
                            fullname = "Danush wickramasingha"
                        },
                        new
                        {
                            id = 4,
                            fullname = "Malith adhikarai"
                        });
                });

            modelBuilder.Entity("myTaskApi.Model.Todo", b =>
                {
                    b.HasOne("myTaskApi.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("Authorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
