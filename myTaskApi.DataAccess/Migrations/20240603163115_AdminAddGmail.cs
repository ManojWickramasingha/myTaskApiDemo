using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class AdminAddGmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gmail",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "id",
                keyValue: 1,
                column: "Gmail",
                value: "wicmanoj15@gmail.com");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "id",
                keyValue: 2,
                column: "Gmail",
                value: "Lahiru10@gmail.com");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "id",
                keyValue: 3,
                column: "Gmail",
                value: "Kasun199@gmail.com");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "id",
                keyValue: 4,
                column: "Gmail",
                value: "malindu23@gmail.com");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "id",
                keyValue: 5,
                column: "Gmail",
                value: "Amil123@gmail.com");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 1, 14, 693, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 6, 3, 22, 1, 14, 693, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 1, 14, 693, DateTimeKind.Local).AddTicks(2376), new DateTime(2024, 6, 3, 22, 1, 14, 693, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 1, 14, 693, DateTimeKind.Local).AddTicks(2387), new DateTime(2024, 6, 3, 22, 1, 14, 693, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 22, 1, 14, 691, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 22, 1, 14, 692, DateTimeKind.Local).AddTicks(7255));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gmail",
                table: "Admins");

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
    }
}
