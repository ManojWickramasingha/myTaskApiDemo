using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EBudgets",
                columns: new[] { "id", "Amount", "Description" },
                values: new object[,]
                {
                    { "c00B", 5000.0, "Education manthly Budget Limit" },
                    { "c01B", 45000.0, "Medical budgets" }
                });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(2094), new DateTime(2024, 6, 3, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(4112), new DateTime(2024, 6, 3, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(4128), new DateTime(2024, 6, 3, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 13, 4, 6, 442, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 13, 4, 6, 443, DateTimeKind.Local).AddTicks(7688));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EBudgets",
                keyColumn: "id",
                keyValue: "c00B");

            migrationBuilder.DeleteData(
                table: "EBudgets",
                keyColumn: "id",
                keyValue: "c01B");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 31, 33, 336, DateTimeKind.Local).AddTicks(8854), new DateTime(2024, 6, 3, 12, 31, 33, 336, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 31, 33, 337, DateTimeKind.Local).AddTicks(1108), new DateTime(2024, 6, 3, 12, 31, 33, 337, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 31, 33, 337, DateTimeKind.Local).AddTicks(1124), new DateTime(2024, 6, 3, 12, 31, 33, 337, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 12, 31, 33, 334, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 12, 31, 33, 336, DateTimeKind.Local).AddTicks(3610));
        }
    }
}
