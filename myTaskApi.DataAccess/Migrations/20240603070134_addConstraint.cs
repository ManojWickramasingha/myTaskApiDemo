using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class addConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "EBudgets",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "EBudgets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(3560), new DateTime(2024, 6, 3, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(6053), new DateTime(2024, 6, 3, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(6073), new DateTime(2024, 6, 3, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 12, 21, 29, 482, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 12, 21, 29, 484, DateTimeKind.Local).AddTicks(7731));
        }
    }
}
