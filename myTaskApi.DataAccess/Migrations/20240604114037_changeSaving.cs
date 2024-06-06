using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class changeSaving : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 10, 36, 34, DateTimeKind.Local).AddTicks(6391), new DateTime(2024, 6, 4, 17, 10, 36, 34, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 10, 36, 34, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 6, 4, 17, 10, 36, 34, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 10, 36, 34, DateTimeKind.Local).AddTicks(8389), new DateTime(2024, 6, 4, 17, 10, 36, 34, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c00b",
                column: "start",
                value: new DateTime(2024, 6, 4, 17, 10, 36, 32, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c01b",
                column: "start",
                value: new DateTime(2024, 6, 4, 17, 10, 36, 34, DateTimeKind.Local).AddTicks(1754));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 6, 58, 188, DateTimeKind.Local).AddTicks(1584), new DateTime(2024, 6, 4, 17, 6, 58, 188, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 6, 58, 188, DateTimeKind.Local).AddTicks(3105), new DateTime(2024, 6, 4, 17, 6, 58, 188, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 6, 58, 188, DateTimeKind.Local).AddTicks(3115), new DateTime(2024, 6, 4, 17, 6, 58, 188, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c00b",
                column: "start",
                value: new DateTime(2024, 6, 4, 17, 6, 58, 186, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c01b",
                column: "start",
                value: new DateTime(2024, 6, 4, 17, 6, 58, 187, DateTimeKind.Local).AddTicks(7957));
        }
    }
}
