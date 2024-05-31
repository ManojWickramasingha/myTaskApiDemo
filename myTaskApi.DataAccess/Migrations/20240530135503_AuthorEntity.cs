using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class AuthorEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 2, 19, 25, 2, 461, DateTimeKind.Local).AddTicks(6622), new DateTime(2024, 5, 30, 19, 25, 2, 461, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 3, 19, 25, 2, 461, DateTimeKind.Local).AddTicks(6646), new DateTime(2024, 5, 30, 19, 25, 2, 461, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 1, 19, 25, 2, 461, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 5, 30, 19, 25, 2, 459, DateTimeKind.Local).AddTicks(311) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 21, 18, 50, 43, 321, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 5, 18, 18, 50, 43, 321, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 22, 18, 50, 43, 321, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 5, 18, 18, 50, 43, 321, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 20, 18, 50, 43, 321, DateTimeKind.Local).AddTicks(3876), new DateTime(2024, 5, 18, 18, 50, 43, 320, DateTimeKind.Local).AddTicks(3814) });
        }
    }
}
