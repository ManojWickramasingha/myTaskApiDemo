using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class SavingEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<float>(
                name: "Save",
                table: "Savings",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(1225), new DateTime(2024, 6, 4, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 6, 4, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(2440), new DateTime(2024, 6, 4, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c00b",
                column: "start",
                value: new DateTime(2024, 6, 4, 21, 40, 3, 63, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c01b",
                column: "start",
                value: new DateTime(2024, 6, 4, 21, 40, 3, 64, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Savings",
                keyColumn: "Id",
                keyValue: 10,
                column: "Save",
                value: 600f);

            migrationBuilder.UpdateData(
                table: "Savings",
                keyColumn: "Id",
                keyValue: 12,
                column: "Save",
                value: 10000f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Save",
                table: "Savings");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Savings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

            migrationBuilder.UpdateData(
                table: "Savings",
                keyColumn: "Id",
                keyValue: 10,
                column: "Amount",
                value: 400.0);

            migrationBuilder.UpdateData(
                table: "Savings",
                keyColumn: "Id",
                keyValue: 12,
                column: "Amount",
                value: 5000.0);
        }
    }
}
