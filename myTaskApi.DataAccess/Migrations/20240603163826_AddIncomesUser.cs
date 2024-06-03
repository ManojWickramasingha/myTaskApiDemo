using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class AddIncomesUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 8, 25, 923, DateTimeKind.Local).AddTicks(488), new DateTime(2024, 6, 3, 22, 8, 25, 923, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 8, 25, 923, DateTimeKind.Local).AddTicks(2472), new DateTime(2024, 6, 3, 22, 8, 25, 923, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 8, 25, 923, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 6, 3, 22, 8, 25, 923, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 22, 8, 25, 921, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 22, 8, 25, 922, DateTimeKind.Local).AddTicks(5822));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
