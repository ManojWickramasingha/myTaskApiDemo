using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class AdminGmailremove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 32, 41, 125, DateTimeKind.Local).AddTicks(33), new DateTime(2024, 6, 3, 19, 32, 41, 124, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 32, 41, 125, DateTimeKind.Local).AddTicks(3479), new DateTime(2024, 6, 3, 19, 32, 41, 125, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 32, 41, 125, DateTimeKind.Local).AddTicks(3505), new DateTime(2024, 6, 3, 19, 32, 41, 125, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 19, 32, 41, 121, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 19, 32, 41, 124, DateTimeKind.Local).AddTicks(2555));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 30, 15, 800, DateTimeKind.Local).AddTicks(435), new DateTime(2024, 6, 3, 19, 30, 15, 800, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 30, 15, 800, DateTimeKind.Local).AddTicks(1850), new DateTime(2024, 6, 3, 19, 30, 15, 800, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 30, 15, 800, DateTimeKind.Local).AddTicks(1861), new DateTime(2024, 6, 3, 19, 30, 15, 800, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 19, 30, 15, 798, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 19, 30, 15, 799, DateTimeKind.Local).AddTicks(7381));
        }
    }
}
