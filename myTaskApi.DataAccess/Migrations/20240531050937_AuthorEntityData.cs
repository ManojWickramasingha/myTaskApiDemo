using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class AuthorEntityData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 39, 36, 956, DateTimeKind.Local).AddTicks(7391), new DateTime(2024, 5, 31, 10, 39, 36, 956, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 39, 36, 956, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 5, 31, 10, 39, 36, 956, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 2, 10, 39, 36, 956, DateTimeKind.Local).AddTicks(4661), new DateTime(2024, 5, 31, 10, 39, 36, 954, DateTimeKind.Local).AddTicks(6941) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
