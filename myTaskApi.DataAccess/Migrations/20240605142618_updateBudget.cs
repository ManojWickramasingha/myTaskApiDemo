using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class updateBudget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(7113), new DateTime(2024, 6, 5, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 6, 5, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 6, 5, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c00b",
                column: "start",
                value: new DateTime(2024, 6, 5, 19, 56, 18, 43, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c01b",
                column: "start",
                value: new DateTime(2024, 6, 5, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(3739));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(4737), new DateTime(2024, 6, 5, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 6, 5, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(6353), new DateTime(2024, 6, 5, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c00b",
                column: "start",
                value: new DateTime(2024, 6, 5, 19, 45, 17, 297, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c01b",
                column: "start",
                value: new DateTime(2024, 6, 5, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(805));
        }
    }
}
